# draught-cli
A Visual Studio Console Application to draw shapes in the terminal (CLI). Supports various drawing primitives (widgets) such as Rectangle, Square, Ellipse, Circle, and Textbox.

## Run App
``dotnet run``

## Run Tests
``dotnet test --logger "console;verbosity=detailed"``

Or, to save to a file: ``dotnet test --logger "trx;LogFileName=testResults.xml"``

## Compile App
``dotnet build``
``dotnet run --project draught_cli`

## Compile App as EXE
``csc Program.cs``

***Publish App:*** ``dotnet publish --configuration Release``

**Run published app**
1. In Explorer, right-click the publish folder (Ctrl-click on macOS), and select Open in Integrated Terminal.
2. Context menu showing Open in Terminal
3. Run the app by using the executable, either by browser to the file in the file explorer, or by using the terminal:
- On Windows, enter .\HelloWorld.exe and press Enter.
- On Linux or Mac, enter ./HelloWorld and press Enter.
4. Enter a name in response to the prompt, and press any key to exit.

**DLL:** On any platform, run the app by using the dotnet command:
- Enter dotnet HelloWorld.dll and press Enter.
- Enter a name in response to the prompt, and press any key to exit.

## Design Decisions

### Class Structure
- Each widget (Rectangle, Square, Ellipse, Circle, Textbox) is represented by a separate class, inheriting from a common base class Widget.
- A Drawing class is responsible for managing a collection of widgets and printing them out.

### Input Validation
- Checks are added to ensure that dimension parameters for widgets are integers and widths, heights, and diameters are positive. 
- Error handling is implemented to manage cases where these checks fail.

### Unit Tests
- Unit tests have been implemented for each widget class and the Drawing class to ensure their correctness.
- Test cases cover the creation and printing of each widget, as well as adding widgets to the drawing.

## Potential Refinements
- Implement more comprehensive unit tests, including edge cases and boundary conditions.
- Add error handling mechanisms for invalid input parameters.
- Implement rendering capabilities to visualize the drawing, even could use Unity.
- Expand functionality to support additional drawing primitives or features such as lines, polygons, color, etc.
- Enhance user interaction by allowing dynamic addition and manipulation of widgets.
- Improve code documentation for better maintainability.

# Challenge

## Demonstration of SOLID principles
Develop a Visual Studio Console Application which simulates a drawing package. Your application should support the following 5 drawing primitives (we'll call them widgets):
1. Rectangle
2. Square
3. Ellipse
4. Circle
5. Textbox

## Requirements
The application should allow widgets to be added to the drawing, stating the location and size/shape of the widget. The location can be a standard x/y coordinate on an imaginary page. The size/shape depends on the widget, as follows:
- Rectangle – width and height
- Square – width
- Ellipse – horizontal and vertical diameter
- Circle – diameter
- Textbox – bounding rectangle (i.e., the rectangle which surrounds the textbox; the text will be centred within this rectangle).

## Clarifications
- Integer units are fine for all dimensions.
- Widths, heights and diameters must be positive.
- For the textbox you only need to configure the text to display (which will be rendered horizontally
within the bounding rectangle). Don’t worry about font face /size / alignment, etc.
- You DO NOT need to concern yourself with handling any input from the user. Our widgets will be hardcoded within the Main() method.
- Your console application should be able to 'print out' the current drawing by printing the key details of each widget (type, location, size/shape) to the console.
- You don't need to actually render the widgets in any manner - we're just simulating a drawing package at this stage.
- You must add one of each widget to the drawing as per the next page

***Important:*** Unit Testing: Please include appropriate unit tests with your solution.

Finally, explain your design decisions in a readme file alongside your submitted solution. Also mention any further work you would do if you had more time.

## Submission 
To submit the exercise, please ensure that all the project files and folders are uploaded in a zip file. Ideally, exclude the bin and obj directories as the presence of executables could risk a delay in your submission being processed due to antivirus processing.

***Grading:*** Your exercise will be evaluated on your ability to follow requirements while demonstrating good programming practices such as: Maintainability, Extensibility, Robustness to changing requirements, testability and SOLID principles. If you’re invited to an interview you will be asked to explain your design choices and you will be asked to amend your solution in response to a requirement change. 

## Simulation
In your Main method, ensure that the following widgets are added.
- rectangle x=10, y=10, width=30 height=40
- square x=15, y=30, size=35
- ellipse x=100, y=150, horizontal diameter=300, vertical diameter=200
- circle x=1, y=1, size=300
- textbox x=5, y=5, width=200, height=100, text="sample text"

***Required Output***
As a result, when running the application, it must produce the following output

***Requested Drawing***
- Rectangle (10,10) width=30 height=40
- Square (15,30) size=35
- Ellipse (100,150) diameterH = 300 diameterV = 200
- Circle (1,1) size=300
- Textbox (5,5) width=200 height=100 Text="sample text"