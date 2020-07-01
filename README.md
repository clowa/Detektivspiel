# Detektivspiel
Learn SQL basics and Relational database management by playing a modern investigation. Use technology to find the theaf and uncover how database technology can be applied to business situations to help you manage your company information.  
The program is **only available in German**.

# Instructions
## Needed:
* MySQL server
* C# compiler
* dotnet framework v4.5.2
* Windows forms compatible operating system

## MySQL server
It's recommended to use a docker container to provide the database. However you can also use xampp or a standalone MySQL server.

## Import the database
You have to import the database "detective game". The corresponding [database dump](Detektivspiel.sql) is located in this repo.

You can import the database eather via the mysql cli client or via a graphical MySQL interface.  
There are probably more ways.

**MySQL cli command:**

```bash
mysql -u [username] -p -h [ip.of.database.host] < [/path/to/dumpfile.sql]
```
You can find more information [here](https://www.digitalocean.com/community/tutorials/how-to-import-and-export-databases-in-mysql-or-mariadb).

**via GUI**

How to import the SQL dump depends on the used tool. Mostly you only need to open the file and run the Query.

## Run the programm
This project was developed at school with Visual Studio 2019.

You can build the .exe by running `dotnet build` within the project directory. The command reference can be find [here](https://docs.microsoft.com/de-de/dotnet/core/tools/dotnet-build).

## Known Issues
* Need to unblock the downloaded files to build and run the projekt.  
  Error message:  
  `Error Couldn't process file frmMain.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files. FinancialCalculations`  
  There are a lot of proposed solutions out there, but this is what worked for me:  
  _Unblock the file in Windows Explorer_
  1. Close the project in Visual Studio
  2. Find the file in Windows Explorer
  3. Right click and go to Properties
  4. On the General tab, look at the bottom where it says `This file came from another computer and might be blocked to help protect this computer.` and click the Unblock checkbox
  Click OK, then re-open the project and try building it again  

  You can also use the powershell [Unblock-File](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/unblock-file?view=powershell-7) cmdlet.

# See also
[verpeteren/SqlDetective](https://github.com/verpeteren/SqlDetective)  
[w3schools SQL reference](https://www.w3schools.com/sql/sql_intro.asp)

# Credits
The original software was developed by IBM. I have rewrite it in C#. The original can be found [here](https://www.ibm.com/developerworks/data/tutorials/dm0804moffatt/index.html).

Icon made by [Freepik](https://www.flaticon.com/authors/freepik) from [www.flaticon.com](http://www.flaticon.com/)
