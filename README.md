# SafeHome

- Currently **Unfinished** (due date: 27/03/17)

### SafeHome is a system composed of a Windows Forms Application (C#), a Web API (ASP.Net) and a Web Forms Application (ASP.Net). These connect to an SQL Server database. 

#### The Windows application allows the user to:
- [x] Design their house
- [x] Mark the location and type of sensors (i.e. Fire alarm, Window alarm, etc.). 
- [ ] Ensures that the house designed is physically feasible (i.e. the bathroom beneath the kitchen if the kitchen is already set to beneath the bathroom)
- [ ] Visualise the entire floor of the house

#### The Web API allows the user to:
- [ ] Submit a data reading
- [ ] Query current state and events
- [ ] Reset the system
- [ ] Switch the system off/on

#### The Web application allows the user to:
- [ ] Submit a data reading for a particular sensor
- [ ] Query current state and events
- [ ] Start / Stop / Reset the system

#### There is a fourth application (Windows Form) which simulates one of the sensors and can:
- [ ] Submit a data reading
- [ ] Trigger an alarm

#### This repo will also contain:
- Design documentation (i.e. UML)
- Captioned screenshots of each of the features
- Critical evaluation of the development of the applications
- Evaluation of how the implementation could be improved
- Explanation of devised algorithms
