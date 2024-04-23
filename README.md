# _Dr.Sillystringz Factory_

#### By _**Jason Falk**_

#### _A Fidgetech Independent Project_

## Technologies Used

* _Html_
* _C#_
* _MySql Workbench_
* _Dotnet_
* _Bootstrap_ 
* _Entity Framework Core, dotnet-ef_
* _dotnet tool install --global dotnet-ef --version 6.0.0_

## Description

_Add installed machines and hired engineers to database and show which engineers are operating which machines._

## Setup/Installation Requirements

1. _Open Git Bash/Open terminal of your choice navigate to directory of your choice and run this command `https://github.com/JasoFal/Dr.Sillystringz-Factory.Solution.git`_
2. _Once you have cloned the project, navigate to project folder using Git Bash/ a terminal of your choice using the cd command. Or you can use file explorer to open the project manually._
3. _Navigate to the project directory, in this case `Factory` using command `cd Factory` in terminal._
4. _Run dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0_
   _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0_
   _dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0_
   _in terminal._
5. _Then once in the `Factory` directory, run: `dotnet build`._
6. _Within the `Factory` directory create file named appsetting.json._
7. _locate file named `appsettings.example.json` and add example code to your appsettings.json adding your UserID and Password. **Warning:** Do not rename the example file as it could have complications with git._
8. _Run `dotnet ef database update` to create database._
------------------
* _Optional Run_
1. _To run the app type `dotnet watch run` in terminal within `Factory` directory._
2. _Then using a browser of your choice enter https://localhost:5001 into search bar._

## Known Bugs

* _No known bugs_

Copyright (c) _4/23/24_ _Jason Falk_