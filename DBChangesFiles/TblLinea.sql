ALTER TABLE dbo.TblLinea ADD CONSTRAINT
	FK_TblMarca_TblLinea FOREIGN KEY
	(
	idMarca
	) REFERENCES dbo.TblMarca
	(
	idMarca
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
GO