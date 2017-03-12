# SafeHome

- Currently **In Progress** (due date: 27/03/17)

### SafeHome is a system composed of a Windows Forms Application (C#), a Web API (ASP.Net) and a Web Forms Application (ASP.Net). These connect to an SQL Server database. 

#### The Windows application allows the user to:
- [x] Design their house
- [x] Mark the location and type of sensors (i.e. Fire alarm, Window alarm, etc.). 
- [x] Ensures that the house designed is physically feasible (i.e. the bathroom beneath the kitchen if the kitchen is already set to beneath the bathroom)
- [x] Visualise the entire floor of the house

#### The Web API allows the user to:
- [x] Submit a data reading
- [x] Query current state and events
- [x] Reset the system
- [x] Switch the system off/on

#### The Web application allows the user to:
- [x] Query current state and events
- [x] Start / Stop / Reset the system
- [x] View events since system was last set

#### There is a fourth application (Windows Form) which simulates one of the sensors and can:
- [x] Submit a data reading
- [x] Trigger an alarm

#### This repo will also contain:
- Design documentation (i.e. UML)
- Captioned screenshots of each of the features
- Critical evaluation of the development of the applications
- Evaluation of how the implementation could be improved
- Explanation of devised algorithms
