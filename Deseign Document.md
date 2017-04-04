# CMPT391FINAL2
Hotel Management System

Introduction: Primary focus of the system is the relationship between the booked rooms and the clients in them.
This relationship does not need needless data such as information concerning the hotel itself. We also assume 
that the Employee can only book from the hotel they are designated at. The schema below shows the relationships.

Discussion: The reason for this design is once we log in with the employee we associate their login with the hotel
they belong too. After that we can save the hotel data within visual studio and not have to run more queries trying
to discern what hotel we are coming from. This is based upon the idea that each employee can only see their hotel 
and can only book clients at their hotel.

This also enables only at most a join of two tables at a time which are the most time consuming processes. As
the data gets larger we than can add more views based on our data to shorten the time it takes further if their
is any time consuming queries. 

Data Warehouse Discussion: The warehouse uses views in order to get the unique information to choose 
from when using the data.For example in the drop down menu for location of hotel there may be two options: USA 
and Canada. These options are made from a query that takes the distinct hotel locations. This is so when populating
all seven dropboxes that require this we aren’t looking through massive amounts of data seven times but only a 
few columns. In the example of USA and canada it would only have to go through a table at the size of two thanks 
to stored procedures. 

Business Rules:
•	Each employee can only see hotel associated with their hotel
•	Each employee can only book clients at their hotel
•	Hotels information is not required to book rooms, are assuming client already knows the hotel before he books. We assume this as this is an employee application, if the client has made contact with the employee we can assume the employee can handle client inquiries such as confirming location. 
•	A client booking automatically ends when the day of his booking ends.
•	A client can have multiple rooms booked
•	A room can only be booked by one person and must not be in use
