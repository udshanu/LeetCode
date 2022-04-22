SELECT date_id, make_name, COUNT(distinct lead_id) AS unique_leads, COUNT(DISTINCT partner_id) AS unique_partners FROM DailySales GROUP BY date_id, make_name ORDER BY make_name DESC, date_id DESC;
