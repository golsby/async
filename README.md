async
=====

A simple example of how to use the async/await pattern in C# 4.5.

Goal: actually perform a time-consuming operation that isn't already wrapped up in a task. That is, I've found myriad examples of how to write code that does asynchronous HTTP requests using code somebody else wrote to do the heavy lifting.

But for Rhino, we need to know how to write and call tasks that do things like intersections and boolean operations.

##Running the Example
  1. Clone this repository
  2. Open async.sln in Visual Studio 2012
  3. Compile and Run
  4. Select a Computation Method
  5. Click Compute...
  6. While the computation is happening, click the Change Background button.
  
##Examples
###Synchronous
This demonstrates and unresponsive UI because the computation is happening on the UI thread.

###Asynchronous
The UI is alive - you can change the background color and move the dialog - but there's no indication of what's going on.

###Asynchronous with Progress
The UI is alive, and periodic progress reports come back from the computation thread.

###Asynchronous with Progress and Cancel
A cancellable operation that reports progress, and of course, keeps the UI alive.

##The Meat
The nugget in this entire example is calling **Task.Run()** to spawn the task I've written in a separate thread. By default, .NET doesn't spawn threads, it uses [cooperative multitasking](http://stackoverflow.com/questions/13993750/the-async-and-await-keywords-dont-cause-additional-threads-to-be-created) on the same thread.
