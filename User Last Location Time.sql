select	users.ID AS ID, 
		users.name as name,
		max_location_times.Location_Time as Location_Time,
		count(users.ID) as location_rank
from users 
join	(select ID, 
				Max(Location_Time) as Location_Time
		from locations
		Group by ID) as max_location_times
on users.ID = max_location_times.ID
group by users.ID, users.name, max_location_times.Location_Time