# _Dr.Sillystringz Factory_

#### By _**Jason Falk**_

#### _A Fidgetech Independent Project_

## Technologies Used

* _Html/C#/Bootstrap_
* _MySql Workbench_
* _Dotnet_

## Description

_Add installed machines and hired engineers to database and show which engineers are operating which machines._

## Setup/Installation Requirements

* _Cloning project_
1. _Open Git Bash/Open terminal of your choice navigate to directory of your choice and run this command `dotnet clone https://github.com/JasoFal/Dr.Sillystringz-Factory.Solution.git`_
2. _Once you have cloned the project, navigate to project folder using Git Bash/ a terminal of your choice using the cd command and run `code .` within project folder. Or you can use file explorer to open the project manually._
* _Navigating to project directory and restoring dependencies_
3. _Navigate to the project directory, in this case **Factory** using command `cd Factory` in terminal._
4. _Then once in the Factory directory, run: `dotnet restore` and `dotnet build`._
* _Setting up appsettings.json file_
5. _Within the **Factory** directory create file named appsetting.json._
6. _locate file named `appsettings.example.json` and add example code to your appsettings.json adding your UserID and Password. **Warning:** Do not rename the example file as it could have complications with git._
* _Creating database_
7. _Run `dotnet ef database update` to create database._
------------------
* _To run the project do the following_
1. _To run the app type `dotnet watch run` in terminal within **Factory** directory._
2. _Then using a browser of your choice enter https://localhost:5001 into search bar._

## Known Bugs

* _No known bugs_

## License

[MIT](License.md)

Copyright (c) _4/23/2024_ _Jason Falk_