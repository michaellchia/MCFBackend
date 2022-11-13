CREATE TABLE ms_storage_location
(
	[location_id] VARCHAR(10) NOT NULL PRIMARY KEY
	,[location_name] VARCHAR(100) NOT NULL
)

CREATE TABLE tr_bpkb
(
	[agreement_number] VARCHAR(100) NOT NULL PRIMARY KEY
	, [bpkb_no] VARCHAR(100) NOT NULL
	, [branch_id] VARCHAR(10) NOT NULL
	, [bpkb_date] DATETIME NOT NULL
	, [faktur_no] VARCHAR(100) NOT NULL
	, [faktur_date] DATETIME NOT NULL
	, [location_id] VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES ms_storage_location(location_id)
	, [police_no] VARCHAR(20) NOT NULL
	, [bpkb_date_in] DATETIME NOT NULL
)