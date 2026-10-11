CREATE TABLE sub_category (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    sub_cat TEXT NOT NULL,
    parent_id INTEGER,
    FOREIGN KEY (parent_id) REFERENCES pdf_table (id) 
        ON DELETE CASCADE
);



SELECT 
    p.id AS parent_id,
    p.name AS parent_name,
    c.data_field AS child_data
FROM parent_table p
INNER JOIN child_table c ON p.id = c.parent_id;




