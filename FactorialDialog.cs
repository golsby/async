using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace async
{
  public partial class FactorialDialog : Form
  {
    CancellationTokenSource m_cancellation_token_source;

    public FactorialDialog()
    {
      InitializeComponent();
    }

    #region Button Handlers
    // Note that this method has to be decorated with async, otherwise I can't 
    // call async methods inside it.
    private async void buttonCompute_Click(object sender, EventArgs e)
    {
      // Initialize the Result field to show we're computing.
      labelResult.Text = "Wait...";

      Int64 n = Convert.ToInt32(txtInput.Text);
      Int64 result = 0;
      Progress<Int64> progress = new  Progress<Int64>();

      switch (comboComputeMethod.Text)
      {
        case "Synchronous":
          // Notice how the UI is unresponsive when using this call.
          result = ComputeFactorial(n, null, CancellationToken.None);
          labelResult.Text = "Answer: " + result.ToString();
          return;
        case "Asynchronous":
          // Here we have a responsive UI, but no indication of progress, and no way to cancel.
          result = await ComputeFactorialAsync(n);
          break;
        case "Async with Progress":
          progress.ProgressChanged += ProgressChanged;
          result = await ComputeFactorialAsync(n, progress);
          break;
        case "Async with Progress and Cancel":
          progress.ProgressChanged += ProgressChanged;
          m_cancellation_token_source = new CancellationTokenSource();
          try
          {
            buttonCancel.Enabled = true;
            result = await ComputeFactorialAsync(n, progress, m_cancellation_token_source.Token);
          }
          catch (OperationCanceledException)
          {
            labelResult.Text = "Computation Cancelled";
            progress.ProgressChanged -= ProgressChanged;
            return;
          }
          finally
          {
            buttonCancel.Enabled = false;
          }
          break;
      }

      // Display the answer.
      labelResult.Text = "Answer: " + result.ToString();
    }

    /// <summary>
    /// Handler for progress reports while computing Factorial
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void ProgressChanged(object sender, Int64 e)
    {
      labelResult.Text = "Computing... " + e.ToString();
    }

    /// <summary>
    /// Toggle background color of the form. This is useful to test if the UI is still alive.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonChangeBackground_Click(object sender, EventArgs e)
    {
      this.BackColor = this.BackColor == Color.White ? Color.Gainsboro : Color.White;
    }

    // Handler for cancel button.
    private void buttonCancel_Click(object sender, EventArgs e)
    {
      if (m_cancellation_token_source != null)
        m_cancellation_token_source.Cancel();
    }
    #endregion

    /// <summary>
    /// Compute Factorial of n on a separate thread.
    /// </summary>
    /// <param name="n">Number to compute factorial from</param>
    /// <returns>The factorial of input 'n'</returns>
    Task<Int64> ComputeFactorialAsync(Int64 n)
    {
      return Task.Run(
        () => ComputeFactorial(n, null, CancellationToken.None)
      );
    }

    /// <summary>
    /// Compute Factorial of n on a separate thread and report progress.
    /// </summary>
    /// <param name="n">Number to compute factorial from</param>
    /// <param name="progress">Optional class to report progress. Pass null if you don't care to receive progress.</param>
    /// <returns>The factorial of input 'n'</returns>
    Task<Int64> ComputeFactorialAsync(Int64 n, IProgress<Int64> progress)
    {
      return Task.Run(
        () => ComputeFactorial(n, progress, CancellationToken.None)
      );
    }

    /// <summary>
    /// Compute Factorial of n on a separate thread, supporting cancellation and reporting of progress.
    /// </summary>
    /// <param name="n">Number to compute factorial from</param>
    /// <param name="progress">Optional class to report progress. Pass null if you don't care to receive progress.</param>
    /// <param name="cancellationToken">Optional CancellationToken. Pass CancellationToken.None if you don't care to cancel.</param>
    /// <returns>The factorial of input 'n'</returns>
    Task<Int64> ComputeFactorialAsync(Int64 n, IProgress<Int64> progress, CancellationToken cancellationToken)
    {
      return Task.Run(
        () => ComputeFactorial(n, progress, cancellationToken)
      );
    }

    /// <summary>
    /// ComputeFactorial is a time consuming function (mostly because it sleeps for half a second at each iteration)
    /// that reports progress and optionally can be cancelled.
    /// </summary>
    /// <param name="n">Number to compute factorial from</param>
    /// <param name="progress">Optional class to report progress. Pass null if you don't care to receive progress.</param>
    /// <param name="cancellationToken">Optional CancellationToken. Pass CancellationToken.None if you don't care to cancel.</param>
    /// <returns>The factorial of input 'n'</returns>
    Int64 ComputeFactorial(Int64 n, IProgress<Int64> progress, CancellationToken cancellationToken)
    {
      Int64 result = 1;
      for (Int64 i = n; i > 1; i--)
      {
        Thread.Sleep(500);
        result *= i;
        if (progress != null)
          progress.Report(result);
        if (cancellationToken.IsCancellationRequested)
          throw new OperationCanceledException();
      }

      return result;
    }

  }
}
