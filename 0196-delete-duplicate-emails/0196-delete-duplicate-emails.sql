/* Write your T-SQL query statement below */
delete p1 
from person p1 inner join person p2
ON p1.Email = p2.Email
AND p1.id > p2.id;