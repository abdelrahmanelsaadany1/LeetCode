select p.product_id ,
round(
    coalesce(
        sum(p.price * ISNULL(u.units, 0)) * 1.0 /
        NULLIF(sum(ISNULL(u.units, 0)), 0),
        0
    )
,2) AS average_price
from Prices p
left join UnitsSold u
on p.product_id = u.product_id
AND u.purchase_date BETWEEN p.start_date AND p.end_date
group by p.product_id