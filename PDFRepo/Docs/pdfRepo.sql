

BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "PDF_table" (
	"id"	INTEGER,
	"pdf_name"	TEXT NOT NULL,
	"pdf_category"	TEXT,
	"pdf_subcat"	TEXT,
	"pdf_created"	TEXT,
	"pdf_size"	TEXT,
	"pdf_attributes"	TEXT,
	"pdf_lastmod"	TEXT,
	"pdf_file"	blob NOT NULL,
	"pdf_description"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "pdf_cat" (
	"id"	INTEGER,
	"category"	TEXT UNIQUE,
	"notes"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "sub_category" (
	"id"	INTEGER,
	"sub_cat"	TEXT UNIQUE,
	"notes"	TEXT,
	"parent_id"	INTEGER,
	PRIMARY KEY("id" AUTOINCREMENT)
);
COMMIT;
