using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async
{
  public partial class ThreadedAsync : Form
  {
    public ThreadedAsync()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }

  class ThreadedTask
  {
    public double Perform() {
      double r = 0.0;
      for (double i = 0; i < 100000; i += 0.005)
      {
        r += Math.Sin(i);
      }
      return r;
    }

  }
}
