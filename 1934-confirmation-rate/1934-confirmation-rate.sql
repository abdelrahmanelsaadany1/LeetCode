/* Write your T-SQL query statement below */
select s.user_id ,SUM(CASE WHEN action = 'confirmed' THEN 1 ELSE 0 END)*1.0/ COUNT(*) AS confirmation_rate
from Signups s left join Confirmations c
on s.user_id=c.user_id
group by s.user_id
order by s.user_id