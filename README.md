# Detektivspiel
Learn SQL basics and relational database management by playing a modern investigation. Use technology to find the theaf and uncover how database technology can be applied to business situations to help you manage your company information.  
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
You have to import the database "detektivspiel". The corresponding [database dump](Detektivspiel.sql) is located in this repo.

You can import the database either via the mysql cli client or via a graphical MySQL interface.  
There are probably more ways.

**MySQL cli command:**

```bash
mysql -u [username] -p -h [ip.of.database.host] < [/path/to/dumpfile.sql]
```
You can find more information [here](https://www.digitalocean.com/community/tutorials/how-to-import-and-export-databases-in-mysql-or-mariadb).

**via GUI**

How to import the SQL dump depends on the used tool. Most times you only need to open the file and run the Query.

## Run the programm
This project was developed at school with Visual Studio.

You can build the .exe by running `dotnet build` within the project directory. The command reference can be find [here](https://docs.microsoft.com/de-de/dotnet/core/tools/dotnet-build).

## Known Issues
### Need to unblock the downloaded files to build and run the projekt.  
  Error message:  
  `Error Couldn't process file FrmMain.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files. FinancialCalculations`  
  There are a lot of proposed solutions out there, but this is what worked for me:  
  _Unblock the file in Windows Explorer_
  1. Close the project in Visual Studio
  2. Find the file in Windows Explorer
  3. Right click and go to Properties
  4. On the General tab, look at the bottom where it says `This file came from another computer and might be blocked to help protect this computer.` and click the Unblock checkbox
  Click OK, then re-open the project and try building it again  

  You can also use the powershell [Unblock-File](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/unblock-file?view=powershell-7) cmdlet.

# Database model

The database consists of four tables: employee, hardware, lobby, and security. It also shows you the type of information stored in each of these tables:

* The *employee* table stores information about each employee such as their employee number, name, manager, office number, phone number, and badge number.
* The *security* table stores information as to when each employee or visitor badged in and out of the building (date and time).
* The *lobby* table stores the badge number assigned to each visitor by name.
* The *hardware* table stores the serial number and type number for every computer along with its location and the ID of the employee who is its primary user.

```
                                               +------------------+  +-----------------+
                                               | Employee         |  | Hardware        |
                                               |------------------|  |-----------------|
                                               | Employee_ID      |<-| Employee_ID     |
                                               | Last_name        |  | Location        |
                           +----------------+  | First_name       |  | Type_number     |
                           | Security       |  | Manager_ID       |  | Serial_number   |
                           |----------------|  | Location         |  +-----------------+
   +------------------+    | Sign_out_date  |  | Extension        |
   | Lobby            |    | Sign_out_time  |  | Gender           |
   |------------------|    | Sign_in_time   |  | Hair_colour      |
   | Badge_number     |<---- Badge_number   |<-| Badge number     |
   | Last_name        |    +----------------+  | Restricted_access|
   | First_name       |                        +------------------+
   +------------------+
```


# See also
[verpeteren/SqlDetective](https://github.com/verpeteren/SqlDetective) if you look for other kind database  
[w3schools SQL reference](https://www.w3schools.com/sql/sql_intro.asp) if you need a sql reference

# Credits
The original software was developed by IBM. I have rewrite it in C#. The original can be found [here](https://www.ibm.com/developerworks/data/tutorials/dm0804moffatt/index.html).

My teacher also write a lot of code of this project. She forces me to mention her.

Icon made by [Freepik](https://www.flaticon.com/authors/freepik) from [www.flaticon.com](http://www.flaticon.com/)
