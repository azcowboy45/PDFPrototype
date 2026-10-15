--
-- File generated with SQLiteStudio v3.4.21 on Thu Oct 15 10:18:55 2026
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: pdf_cat
CREATE TABLE IF NOT EXISTS pdf_cat (
    id       INTEGER,
    category TEXT    UNIQUE,
    notes    TEXT,
    PRIMARY KEY (
        id AUTOINCREMENT
    )
);


-- Table: PDF_table
CREATE TABLE IF NOT EXISTS PDF_table (
    id              INTEGER,
    pdf_name        TEXT    NOT NULL,
    pdf_category    TEXT,
    pdf_subcat      TEXT,
    pdf_created     TEXT,
    pdf_size        TEXT,
    pdf_attributes  TEXT,
    pdf_lastmod     TEXT,
    pdf_file        BLOB    NOT NULL,
    pdf_description TEXT,
    PRIMARY KEY (
        id AUTOINCREMENT
    )
);


-- Table: sub_category
CREATE TABLE IF NOT EXISTS sub_category (
    id        INTEGER PRIMARY KEY AUTOINCREMENT,
    sub_cat   TEXT,
    notes     TEXT,
    parent_id INTEGER,
    FOREIGN KEY (
        parent_id
    )
    REFERENCES pdf_table (id) ON DELETE CASCADE
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
