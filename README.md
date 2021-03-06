# World

#### .NET MVC app that allows the user to filter on a list of Countries, or sort a list of Cities. 2/19/2018.

#### _By Kayla Ondracek and Sara Hamilton_

## Description
_This is an Epicodus practice project for Monday of week 3 of the C# course. Its purpose is for practicing accessing and selecting values from a database of country/city values._

#### _World_
* Displays a list of Countries and related info
* Allows user to filter on the list of Countries based on user-provided values
* Displays a list of Cities and related info
* Allows user to sort list of Cities ascending or descending on the various City attributes.

### Specifications
* In Countries View, allow users to filter results by any column
  * sample input: filter by country code "USA"
  * sample output: "USA,	United States,	North America	North America,	278357000"
* In Cities view, allow users to choose whether to order the cities in ascending or descending order.
  * sample input: Sort by Population descending
  * sample output: sorted list descending by population


  ## Setup/Installation Requirements

  * _Clone this GitHub repository_

  ```
  git clone https://github.com/Sara-Hamilton/World.git
  ```

  * _Install the .NET Framework and MAMP_

    .NET Core 1.1 SDK (Software Development Kit)

    .NET runtime.

    MAMP

    See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

  * _Import the data into the database_
    See https://www.learnhowtoprogram.com/c/database-basics-ee7c9fd3-fcd9-4fff-8b1d-5ff7bfcbf8f0/database-practice-and-world-data for instructions and links.
    Download the zip file in the World Data section.

    See https://www.learnhowtoprogram.com/c/database-basics-ee7c9fd3-fcd9-4fff-8b1d-5ff7bfcbf8f0/exporting-mysql-databases-in-phpmyadmin for instructions if link on above page doesn't work.

  * _Run the program_
    1. In the command line, cd into the project folder.
    2. In the command line, type dotnet restore. Enter.  It make take a few minutes to complete this process.
    3. In the command line, type dotnet build. Enter. Any errror messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
    4. In the command line, type dotnet run. Enter.

  * _View program on web browser at port localhost:5000/_

  * _Follow the prompts._

  ## Support and contact details

_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* Bootstrap
* C#
* MAMP
* .Net Core 1.1

### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton and Kayla Ondracek_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
