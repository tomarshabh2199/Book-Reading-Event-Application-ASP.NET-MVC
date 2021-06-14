# Book-Reading-Event-Application-ASP.NET-MVC

 create an application to manage book-reading events. It will allow managing events across world wide. A book reading event is where book lovers come together for a community reading of their favourite book. One or more readers read the book loudly and optionally people even play different roles from the book!
 
 
 				
Page			                                                 Is Mandatory?	Notes

1	Create a book reading event (only for logged in users)			
	Title	string	Yes	
	Date	datetime	Yes	Can be in past. Used to add previous events for record-keeping purpose
	location	  string	    Yes	
	start time	dropdown (from 00:00 to 2300)		
	Type	Public/Private		default public
	Duration in hours	int	  No	   Maximum 4
	Description	   string	   No	       Max   50 characters
	Other Details	 string	  No	     Max   500 characters
	Invite by email	string	No	comma-separated email of users to invite
				
2	Edit a book reading event (only for logged in users)			
	Same fields as "Create"			
	Events with start date in past cannot be edited			
				
3	View a book reading event			
	Title	As entered	Yes	
	Date	As entered	Yes	
	location	As entered	Yes	
	start time	As entered		
	Duration in hours	As entered	No	Show only if entered during creation
	Description	As entered	No	Show only if entered during creation
	Other Details	As entered	No	Show only if entered during creation
	Total invited to event	As entered	Yes	Count number of emails and show as int
	Comments	string	No	Allow the user to post a comment on the event
	Past comments	List of older comments	-	If there are past comments, show them below comments box. Sort by oldest comment first.
				
4	Create User/Register			
	Email	string	Yes	Check for duplicacy and disallow registration for duplicate users
	Password	string	Yes	Masked field. Must be at least 5 characters and contain at least one special character.
	Full Name	string	Yes	
				
5	Homepage			
	Upcoming events	Show title as hyperlink		Hyperlink takes user to event details page
	Past Events	Show title as hyperlink		Hyperlink takes user to event details page
				
6	My events (only for logged in users)			
	All events by current user	Show title as hyperlink		"- Hyperlink takes user to event details page.
- Sorted by latest event-start-date first.
- Show an edit link next to each event to allow editing"
				
7	Events invited to (only for logged in users)			
	All events where user was invited	Show title as hyperlink		Hyperlink takes user to event details page
				
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


