SELECT  name,unique_id 
from Employees E
left join EmployeeUNI EU on E.id=EU.id  ;

