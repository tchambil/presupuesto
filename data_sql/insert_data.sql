--INSERTED TABLE SICOP_META
INSERT SICOP_META VALUES('0034','ADMINISTRACIÓN')
INSERT SICOP_META VALUES('0062','TURISMO')
INSERT SICOP_META VALUES('0063','COMERCIO') 

--INSERTED TABLE SICOP_ESPECIFICADEGASTO 
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.11.12','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.11.13','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.11.21','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.19.12','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.19.13','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.21.11','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.1.31.15','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.3.11.11','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.3.12.11','Name')
INSERT SICOP_ESPECIFICADEGASTO VALUES('52.3.12.13','Name') 

--INSERTED TABLE SICOP_DOCUMENTO 
INSERT SICOP_DOCUMENTO VALUES('PLL. REMUNERACIÓN')
INSERT SICOP_DOCUMENTO VALUES('PLL. CAS')
INSERT SICOP_DOCUMENTO VALUES('PLL. PRAC')
INSERT SICOP_DOCUMENTO VALUES('O/C ORDEN COMPRA')
INSERT SICOP_DOCUMENTO VALUES('O/S ORDEN SERVICIO')
INSERT SICOP_DOCUMENTO VALUES('OTROS')

--INSERTED TABLE SICOP_META_ESPECIFICADEGASTO 
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.11.12',57460,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.11.13',13406,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.11.21',146940,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.19.12',4200,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.19.13',2800,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.21.11',2800,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.1.31.15',6467,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.3.11.11',1993,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.3.12.11',103,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0034','52.3.12.13',94,'2015') 

INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.11.12',60941,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.11.21',122520,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.19.12',3600,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.19.13',2400,'2015')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.21.11',2400,'2014')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.1.31.15',5526,'2014')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.3.11.11',2136,'2013')
INSERT SICOP_META_ESPECIFICADEGASTO  VALUES('0062','52.3.12.11',498,'2014')

-----------------------------------------------------------------------------

--INSERTED TABLE SICOP_CONTROLPRESUPUESTAL

INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.13','1','PLLA3','21-04-2015','4611','4611','19-05-2015','21-05-2015','Telefonica','Telefonia Fija','5302.070502')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.21','1','PLLA3','21-04-2015','4615','4615','19-05-2015','21-05-2015','Vilca Gonzales Patty Anita','Decoracion refrigerios','5302.0801')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.19.12','2','PLLA3','21-04-2015','4965','4965','19-05-2015','21-05-2015','Nina Cruz Yuli Vicencia','Banderolas','5302.0801')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','2','PLLA3','21-01-2015','4965','4965','19-05-2015','21-05-2015','Nina Cruz Yuli Vicencia','Banderolas','5302.0801')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','3','PLLA3','21-02-2015','4965','4965','19-05-2015','21-05-2015','Nina Cruz Yuli Vicencia','Banderolas','5103.01')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','3','PLLA3','21-03-2015','4965','4965','19-05-2015','21-05-2015','Nina Cruz Yuli Vicencia','Banderolas','1301.050102')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','4','PLLA3','21-05-2015','4965','4965','19-05-2015','21-05-2015','Nina Cruz Yuli Vicencia','Banderolas','1301.050102')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','4','PLLA3','21-04-2015','4794','4479','19-05-2015','21-05-2015','Eva Graciela Soto Mayor Ninaja','Practicante','1301.9904')
INSERT SICOP_CONTROLPRESUPUESTAL  VALUES('52.1.11.12','5','PLLA3','21-04-2015','4794','4479','19-05-2015','21-05-2015','Eva Graciela Soto Mayor Ninaja','Practicante','1301.9904')

--INSERTED TABLE SICOP_DETALLECONTROLPRESUPUESTAL

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('1','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('1','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('1','52.1.11.12','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('2','52.1.11.13','0034',100)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('2','52.1.11.13','0062',200)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('2','52.1.11.13','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('3','52.1.11.21','0034',0)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('3','52.1.11.21','0062',235)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('3','52.1.11.21','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('4','52.1.11.12','0034',500)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('4','52.1.11.12','0062',235)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('4','52.1.11.12','0063',25)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('5','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('5','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('5','52.1.11.12','0063',0)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('6','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('6','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('6','52.1.11.12','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('7','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('7','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('7','52.1.11.12','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('8','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('8','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('8','52.1.11.12','0063',0)

INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('9','52.1.11.12','0034',180)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('9','52.1.11.12','0062',220)
INSERT SICOP_DETALLECONTROLPRESUPUESTAL  VALUES('9','52.1.11.12','0063',0)
