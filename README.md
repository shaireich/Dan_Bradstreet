====Technical Overview====

1. Opened project of ASP.NET Web Application and chose Template of Web Api with MVC reference.
2. Add classes (Only my Procedure in sql,without tables) and Connection to DB by configured EntityFramework, 
   with the help of Context Class - "DanBEntities", i would be able to get data from DB.
3. Add Controller - "ProcedureController", which be the middleman between Context Class and the client (in my case-web browser).
   I created Entry Point which tell api's user to choose One Of Get Request Template.
   The controller built on 3 functions, each responsible on one of the sql stored procedure.

====API Instructions==== 

Run the project and write each url after your localhost number.
---List all Functions in the project---
==1==
Function GetOneProcedure
Description of function  - Write year which appear in "ORDERS" Table and recieve the agent code's sum of "ADVANCE_AMOUNT" field of all his orders                             
                           in first quarter of this year.
Parameter - year
Datatype - int
Required - yes
Example Of Request - /Procedure/GetOneProcedure/?year=2021
==2==
Function GetTwoProcedure
Description of function - Write list of Agent Code which appear in "AGENTS" Table and num of line you want to recieve from each Agent.

Parameter - listAgentCode
Datatype - string
Required - yes

Parameter - numOfLine
Datatype - int
Required - yes

Example Of Request - /Procedure/GetTwoProcedure/?listAgentCode=A004,A009&numOfLine=2
==3==
Function GetThreeProcedure
Description of function - Write year of orders appear in "ORDERS" Table and num orders. 
                          Function will return the agents code which have more or equal orders then input of "numOfOrders" parameter.

Parameter - year
Datatype - int
Required - yes

Parameter - numOfOrders
Datatype - int
Required - yes

Example Of Request - /Procedure/GetThreeProcedure/?year=2021&numOfOrders=3

