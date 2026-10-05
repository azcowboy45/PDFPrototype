tableCreationPDFrepo.sql

CREATE TABLE PDF_table (
		id INTEGER, 
		pdf_name TEXT NOT NULL, 
		pdf_file blob NOT NULL, 
		pdf_description TEXT, 
		pdf_category TEXT, 
		pdf_created TEXT, 
		pdf_size TEXT, 
		pdf_attributes TEXT, 
		pdf_lastmod TEXT, 
	PRIMARY KEY (id AUTOINCREMENT))


CREATE TABLE "pdf_cat" (
	"id"	INTEGER,
	"category"	TEXT,
	"notes"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT))
