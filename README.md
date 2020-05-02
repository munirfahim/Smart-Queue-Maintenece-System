# Smart-Queue-Maintenece-System (C#, MSSQL, Entity Framework) SQL backup included

An automated system to manage long customer/participants queues for any event. Based on event date and time, number of terminals to serve people, estimated time needed for each people ahead- a estimated time is given to customers which will be updating based on queue progress. 



# User – Organization: 
Create an event with dates and time ranges; Create multiple terminal to manage queue, Terminal gets auto generated token number to call next person after finishing the task of previous person; Mark those who missed their appointment

![image](https://user-images.githubusercontent.com/57692222/80872268-b96a6580-8cd2-11ea-98e5-102ecacf11c1.png)

![image](https://user-images.githubusercontent.com/57692222/80872482-0ac72480-8cd4-11ea-9dc7-3393ef231aef.png)

![image](https://user-images.githubusercontent.com/57692222/80872491-16b2e680-8cd4-11ea-9a58-04cd0fe8c7f9.png)

![image](https://user-images.githubusercontent.com/57692222/80872498-229ea880-8cd4-11ea-91cf-689b68a3567f.png)

![image](https://user-images.githubusercontent.com/57692222/80872525-4530c180-8cd4-11ea-9464-bba9e300629d.png)

![image](https://user-images.githubusercontent.com/57692222/80872540-58439180-8cd4-11ea-9191-3290e28715d3.png)


# User: Customer/ Participant: 
Create appointment for particular event; Get real time update of expected time remaining for his/her call based on how many terminals are running, amount of people ahead in the queue, expected time needed for them to complete their appointment.


![image](https://user-images.githubusercontent.com/57692222/80872268-b96a6580-8cd2-11ea-98e5-102ecacf11c1.png)

![image](https://user-images.githubusercontent.com/57692222/80872294-ce46f900-8cd2-11ea-8670-131b269d7793.png)

![image](https://user-images.githubusercontent.com/57692222/80872552-6f827f00-8cd4-11ea-9f4c-668bced2478d.png)

![image](https://user-images.githubusercontent.com/57692222/80872509-33e7b500-8cd4-11ea-8112-2da98624f096.png)


# Entity .edmx Diagram:

![image](https://user-images.githubusercontent.com/57692222/80872578-904ad480-8cd4-11ea-8157-9b5de4fce238.png)
