# Book-Reading-Event-Application-ASP.NET-MVC

 create an application to manage book-reading events. It will allow managing events across world wide. A book reading event is where book lovers come together for a community reading of their favourite book. One or more readers read the book loudly and optionally people even play different roles from the book!
 
 			
![image](https://user-images.githubusercontent.com/44699205/121894610-f493f080-cd3c-11eb-8a44-5b77a002901e.png)


###
#High level requirements and specifications are as below:
-	Home page 
o	Displays all public events as hyperlinks. There should be 2 columns, one for past events and one for future events. 
o	Clicking hyperlink takes user to event details page.
o	Logged in users see additional header items: “My events”, “Events invited to”, “Create event”
-	A book reading event has 
o	Title of the book, date of the event, location and start time. 
o	Optionally, the event organizer may also specify the duration, description and other details.
-	The event can be marked as public or private.
-	The event creator can add people to the event by specifying their email. Multiple people can be invited by specifying multiple, comma-separated emails.
-	Users can register on the website to create their own events. 
-	Anonymous users can only view public events
-	“Events invited to” (visible to logged in users) will list all events as hyperlinks where the current logged in user was invited to (by matching email). Even private events are shown here if the user was invited. Hyperlinks redirect to event details page.
-	“My events” (visible to logged in users) shows all events created by user, sorted by newest event-start-date first. There should be an “Edit” link in front of each entry which allows to edit the event.
o	User can edit only the events that (s)he created!
-	Create a user with a specific hard-coded email, for example “myadmin@bookevents.com”. This user will be treated as an administrator for the system (will have admin role).
o	Admin user can edit ANY event
o	The list of events will show ALL events for him, whether public/private
-	Add a special url called “/customer-support” that simply redirects to helpdesk.nagarro.com 

#Technical considerations:
-	Add a unit test project and write unit test cases for at least 5 business methods; any method(s).
-	Validate at both server and client side (Use some fluent validation on server side).
-	Use [Authenticate] and [Authorize] attributes for authentication and authorization
-	Use sample framework
-	Add interceptor and log all DB commands to console


