Use eGasCore
select * from aspnetusers
update aspnetusers set EmailConfirmed=1

select * from instructor
select * from cities
select * from areas
select * from educationQualifications



-- alter table educationQualifications drop constraint educationQualifications
--drop educationQualificationeducationQualificationID

ALTER TABLE instructor         
DROP Foreign Key (educationQualificationID)