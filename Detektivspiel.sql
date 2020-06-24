
DROP DATABASE detektivspiel;
CREATE DATABASE detektivspiel;
USE detektivspiel;

-- Table SECURITY

CREATE TABLE security  (
    badge_number CHAR(5) NOT NULL PRIMARY KEY,
    sign_out_date DATE,
    sign_out_time TIME,
    sign_in_time TIME
    );


-- Table EMPLOYEE

CREATE TABLE employee (
    employee_id CHAR(6) NOT NULL PRIMARY KEY,
    first_name VARCHAR(20),
    last_name VARCHAR(20),
    location CHAR(6),
    manager_id CHAR(6),
    extension CHAR(4),
    gender CHAR(1),
    hair_colour CHAR(6),
    badge_number CHAR(5),
    restricted_access CHAR(1)
    );


-- Table LOBBY

CREATE TABLE lobby (
    first_name VARCHAR(20),
    last_name VARCHAR(20),
    badge_number CHAR(5) NOT NULL PRIMARY KEY,
	FOREIGN KEY (badge_number)	REFERENCES security (badge_number)
    );


-- Table HARDWARE

CREATE TABLE hardware (
    employee_id CHAR(6),
    location CHAR(6),
    hardware_tn CHAR(8),
    hardware_sn CHAR(8) NOT NULL PRIMARY KEY
    );


ALTER TABLE hardware
    ADD CONSTRAINT fk_hardware_emp FOREIGN KEY (employee_id)
	REFERENCES employee (employee_id);
	
	INSERT INTO security (badge_number, sign_out_date, sign_out_time, sign_in_time) VALUES 
('34532','2003-04-07','17:14:00','09:22:00'),
('24623','2003-07-04','18:23:00','10:03:00'),
('24724','2003-07-05','16:53:00','08:47:00'),
('97586','2003-07-03','17:43:00','11:33:00'),
('23735','2003-07-04','19:00:00','03:05:00'),
('67254','2003-07-04','16:00:00','13:05:00'),
('43358','2003-07-04','15:45:00','11:05:00'),
('42358','2003-07-04','17:25:00','08:45:00'),
('43458','2003-07-05','16:34:00','09:25:00'),
('43238','2003-07-04','12:54:00','06:55:00'),
('87348','2003-07-04','17:54:00','07:55:00'),
('92033','2003-07-04','18:23:00','08:35:00'),
('23033','2003-07-04','18:23:00','08:35:00'),
('23045','2003-07-04','18:23:00','08:35:00'),
('76434','2003-07-04','18:23:00','08:35:00'),
('86434','2003-07-04','13:23:00','05:35:00'),
('82534','2003-07-04','16:33:00','05:46:00'),
('82574','2003-07-05','16:33:00','05:46:00'),
('62574','2003-07-03','14:33:00','05:36:00'),
('83454','2003-07-04','18:19:00','07:26:00'),
('83457','2003-07-04','19:10:00','07:42:00'),
('83458','2003-07-04','17:10:00','08:42:00'),
('83459','2003-07-04','16:47:00','09:12:00'),
('83460','2003-07-04','16:34:00','09:22:00'),
('83461','2003-07-04','17:44:00','08:29:00'),
('83462','2003-07-04','18:14:00','09:39:00'),
('83463','2003-07-04','18:47:00','11:04:00'),
('83464','2003-07-04','13:47:00','06:04:00'),
('83465','2003-07-04','15:47:00','06:58:00'),
('83466','2003-07-04','17:47:00','08:58:00'),
('83467','2003-07-04','17:47:00','08:58:00'),
('83468','2003-07-04','15:27:00','09:08:00'),
('83469','2003-07-04','16:59:00','09:14:00'),
('83470','2003-07-04','17:19:00','08:14:00'),
('83471','2003-07-04','16:14:00','08:24:00'),
('83472','2003-07-04','16:54:00','09:04:00'),
('83473','2003-07-04','16:54:00','09:04:00'),
('83474','2003-07-04','20:15:00','10:04:00'),
('83475','2003-07-04','17:45:00','08:44:00'),
('83476','2003-07-04','14:45:00','09:30:00'),
('83477','2003-07-04','16:47:00','09:23:00'),
('83478','2003-07-04','16:47:00','09:23:00'),
('83479','2003-07-04','16:35:00','10:28:00'),
('83480','2003-07-04','17:25:00','08:55:00'),
('83481','2003-07-04','17:24:00','09:25:00'),
('83482','2003-07-04','14:44:00','07:53:00'),
('83483','2003-07-04','16:27:00','08:51:00'),
('83484','2003-07-04','17:07:00','09:23:00'),
('83485','2003-07-04','22:07:00','09:16:00'),
('83486','2003-07-04','22:07:00','09:16:00'),
('83487','2003-07-05','12:07:00','09:16:00'),
('83488','2003-07-05','12:07:00','09:16:00'),
('83489','2003-07-02','16:07:00','08:16:00'),
('83490','2003-07-02','17:34:00','08:16:00'),
('83491','2003-07-02','15:34:00','09:16:00'),
('83492','2003-07-07','16:44:00','09:06:00'),
('83493','2003-07-07','17:14:00','09:06:00'),
('83494','2003-07-07','17:23:00','09:45:00'),
('83495','2003-07-07','14:25:00','10:25:00'),
('83496','2003-07-07','14:25:00','08:28:00'),
('83497','2003-07-07','14:25:00','08:28:00'),
('83498','2003-07-06','14:25:00','08:28:00'),
('83499','2003-07-06','18:21:00','09:36:00'),
('83500','2003-07-06','18:21:00','09:36:00'),
('83501','2003-07-03','18:21:00','09:36:00'),
('83502','2003-07-03','17:31:00','09:05:00'),
('83503','2003-07-03','17:01:00','08:59:00'),
('83504','2003-07-03','15:48:00','09:39:00'),
('83505','2003-07-03','17:48:00','09:19:00'),
('83506','2003-07-03','17:18:00','09:29:00'),
('83507','2003-07-02','16:08:00','09:15:00'),
('83508','2003-07-02','18:18:00','09:36:00'),
('83509','2003-07-05','18:18:00','09:36:00'),
('83510','2003-07-05','18:28:00','08:56:00'),
('83511','2003-07-05','16:20:00','08:51:00'),
('83512','2003-07-05','12:30:00','09:11:00'),
('83513','2003-07-05','17:30:00','09:11:00'),
('83514','2003-07-06','17:21:00','09:00:00'),
('83515','2003-07-06','15:26:00','08:40:00'),
('83516','2003-07-07','16:26:00','08:47:00'),
('83517','2003-07-07','18:06:00','09:07:00'),
('83518','2003-07-07','17:06:00','09:01:00'),
('83519','2003-07-08','16:16:00','09:21:00'),
('83520','2003-07-08','17:46:00','09:17:00'),
('83521','2003-07-08','17:46:00','09:17:00'),
('83522','2003-07-08','17:46:00','09:17:00'),
('83523','2003-07-07','16:59:00','09:02:00'),
('83524','2003-07-02','15:51:00','08:02:00'),
('83525','2003-07-02','13:21:00','08:46:00'),
('83526','2003-07-02','18:01:00','08:56:00'),
('83527','2003-07-02','20:07:00','10:56:00'),
('83528','2003-07-02','17:07:00','09:36:00'),
('83529','2003-07-03','17:07:00','09:26:00'),
('83530','2003-07-03','16:38:00','09:09:00'),
('83531','2003-07-03','16:59:00','09:03:00'),
('83532','2003-07-03','17:29:00','09:15:00'),
('83533','2003-07-03','17:29:00','08:15:00'),
('83534','2003-07-03','17:29:00','08:15:00'),
('83535','2003-07-03','17:29:00','08:16:00'),
('83536','2003-07-03','17:02:00','08:16:00'),
('83537','2003-07-03','16:02:00','09:16:00'),
('83538','2003-07-03','17:26:00','09:16:00'),
('83539','2003-07-03','17:16:00','09:03:00'),
('83540','2003-07-03','18:02:00','09:12:00'),
('83541','2003-07-07','17:32:00','09:17:00'),
('83542','2003-07-07','17:32:00','09:17:00'),
('83543','2003-07-07','17:15:00','09:13:00'),
('83544','2003-07-07','17:05:00','09:23:00'),
('83545','2003-07-07','17:03:00','10:13:00'),
('83546','2003-07-07','16:03:00','08:13:00'),
('83547','2003-07-07','18:03:00','08:53:00'),
('83548','2003-07-07','16:03:00','08:43:00'),
('83549','2003-07-07','16:03:00','08:43:00'),
('83550','2003-07-07','17:03:00','09:43:00'),
('83551','2003-07-07','17:01:00','09:23:00'),
('83552','2003-07-07','17:21:00','09:16:00'),
('83553','2003-07-07','17:21:00','09:16:00'),
('83554','2003-07-07','16:41:00','09:17:00'),
('83555','2003-07-07','16:41:00','09:07:00'),
('83556','2003-07-07','17:41:00','09:27:00'),
('83557','2003-07-07','17:11:00','09:32:00'),
('83558','2003-07-07','17:11:00','09:32:00'),
('83559','2003-07-07','18:32:00','10:52:00'),
('83560','2003-07-07','16:32:00','08:52:00'),
('83561','2003-07-07','17:09:00','08:52:00'),
('83562','2003-07-07','17:09:00','09:12:00'),
('83563','2003-07-07','17:07:00','09:12:00'),
('83564','2003-07-07','17:31:00','09:02:00'),
('83565','2003-07-07','17:31:00','09:02:00'),
('83566','2003-07-07','16:21:00','09:02:00'),
('83567','2003-07-07','16:26:00','09:18:00'),
('83568','2003-07-07','18:26:00','09:28:00'),
('83569','2003-07-07','17:26:00','09:18:00'),
('83571','2003-07-07','16:21:00','08:13:00'),
('83572','2003-07-07','17:23:00','09:12:00'),
('83573','2003-07-07','17:23:00','09:12:00'),
('83574','2003-07-07','17:45:00','09:24:00'),
('83575','2003-07-07','17:45:00','09:24:00'),
('83576','2003-07-07','17:46:00','09:21:00'),
('83577','2003-07-07','17:46:00','09:21:00'),
('83578','2003-07-07','17:56:00','09:11:00'),
('V0058','2003-07-03','13:18:00','10:29:00'),
('V0059','2003-07-04','16:18:00','15:45:00'),
('V0060','2003-07-04','18:18:00','16:23:00'),
('V0061','2003-07-05','16:38:00','15:23:00'),
('V0062','2003-07-04','15:59:00','15:23:00'),
('V0063','2003-07-04','19:29:00','18:23:00'),
('V0064','2003-07-05','13:46:00','12:23:00'),
('V0065','2003-07-04','12:50:00','11:26:00'),
('V0066','2003-07-04','16:50:00','14:26:00'),
('V0067','2003-07-04','17:04:00','15:26:00');

INSERT INTO employee (employee_id, first_name, last_name, location, manager_id, extension, gender, hair_colour, badge_number, restricted_access) VALUES 
('534373','William','Miller','B3-268','278354','3453','M','brown     ','24623','N'),
('73732 ','Jagadish','Dara','C2-762','278354','2442','M','black     ','24724','N'),
('897575','Oleg','Glembotsky','C2-123','825474','3426','M','black     ','97586','N'),
('262745','Oleg','Glembotsky','A4-324','234445','8453','M','black     ','23735','Y'),
('629832','Colin','Humber','A2-462','278354','1235','M','blonde    ','67254','Y'),
('847254','Simone','Tufenkjian','A1-422','825474','1365','M','black     ','43358','N'),
('252254','Fernando','Rocha','B3-252','234445','1742','M','black     ','42358','N'),
('243354','Nelson','Icuma','B4-222','','6532','M','black     ','43458','N'),
('278354','Claudinei','Santana','B1-772','234445','6632','F','black     ','43238','Y'),
('893454','Vlaunir','Jimenez da Silva','C1-742','825474','3432','M','brown     ','87348','N'),
('893445','Juliana','Santos','C1-734','825474','6432','M','brown     ','92033','N'),
('234445','Sissi','Pereira','D1-734','','5532','F','brown     ','23033','N'),
('823474','Claudia','Pelster','D2-736','278354','5535','F','blonde    ','23045','N'),
('825474','Paulo Henrique','Guimar?es','D3-536','243354','5535','M','black     ','76434','Y'),
('673574','Marco','Poma','D2-524','278354','5355','M','black     ','86434','N'),
('673774','Agnaldo','Santos','C2-524','278354','5365','M','black     ','82534','N'),
('257674','Tania','Okay','C2-784','924660','6365','M','grey      ','82574','N'),
('983674','Maria','Rocha','C2-484','924689','6365','F','grey      ','62574','N'),
('924574','Kelly','Goedert','A2-554','825474','6785','F','brown     ','83454','N'),
('924575','Wim','Drossaert','B2-554','825474','6795','M','grey      ','83457','Y'),
('924576','Gustav','Eissner','B2-654','243354','6273','M','black     ','83458','N'),
('924577','Slava','Ikitjuk','B3-644','924576','3223','F','black     ','83459','N'),
('924578','Frank','Proesmans','B3-454','924576','5555','M','brown     ','83460','N'),
('924579','Judy','Lau','D3-294','924576','3223','F','brown     ','83461','N'),
('924580','Marc','Ost','D1-294','924576','3423','M','brown     ','83462','Y'),
('924581','Joao','Vendruscolo','D1-283','924576','3424','M','brown     ','83463','N'),
('924582','Roberto','Guardiola','A3-273','924576','3425','M','black     ','83464','N'),
('924583','Carla','Silva','B3-273','243354','3425','F','brown     ','83465','N'),
('924584','Paulo','Garcia','B3-123','924583','3426','F','black     ','83466','Y'),
('924585','Sandra','Pereira','B4-143','924583','3427','F','brown     ','83467','N'),
('924586','Leandro','Dal B?','C4-143','924583','3428','M','black     ','83468','N'),
('924587','Hilario','Sano','C1-223','924583','3429','F','black     ','83469','N'),
('924588','Ruiyuan','Liu','C1-563','924583','3430','M','black     ','83470','Y'),
('924589','Silvia','Dempaire','C1-593','924583','3430','F','black     ','83471','Y'),
('924590','Jonathan','Sy','C4-533','243354','3431','M','grey      ','83472','N'),
('924591','Dat Nhan','Trinh','C3-453','924590','3432','M','black     ','83473','N'),
('924592','Yeek','Tjia','B3-783','924590','3433','F','black     ','83474','Y'),
('924593','Robert','Gaisbauer','B3-663','924590','3434','M','brown     ','83475','N'),
('924625','Phillip','Zhou','C2-466','252254','3463','M','black     ','83507','N'),
('924594','Daniel','Miralles','D3-653','924590','3434','M','blonde    ','83476','N'),
('924595','Rajesh','Gopalakrishnan','D2-653','924590','3435','M','brown     ','83477','N'),
('924596','Matthew','Watson','D2-648','924590','3436','M','brown     ','83478','N'),
('924597','Kalyanasundaram','Sankarasubramaniam','A2-248','252254','3437','M','brown     ','83479','N'),
('924598','Horace','Kwong','A4-247','924597','3438','M','black     ','83480','N'),
('924599','Yafang','Hu','A1-238','924597','3439','M','black     ','83481','N'),
('924600','Jeff','Brennan','B2-738','924597','3440','M','blonde    ','83482','Y'),
('924601','Oscar','Souza','B3-718','924597','3441','M','blonde    ','83483','N'),
('924602','Grant','Allen','B3-713','924597','3442','M','brown     ','83484','N'),
('924626','Domingos','Fernandes','C2-536','924625','3464','M','black     ','83508','N'),
('924603','Ning','Zhang','C3-712','924597','3442','F','black     ','83485','N'),
('924604','Paul','Kessler','C4-312','252254','3442','M','black     ','83486','N'),
('924605','Shiyou','Chen','C4-213','924604','3443','F','black     ','83487','N'),
('924606','Eileen','Kilfoil','B4-213','924604','3444','F','blonde    ','83488','Y'),
('924607','Suby','Raju','B3-223','924604','3445','F','blonde    ','83489','N'),
('924608','David','Houghton','A1-623','924604','3446','M','black     ','83490','N'),
('924609','Alaric','Wang','A1-523','924604','3447','M','black     ','83491','N'),
('924610','Jurica','Bekavac','D1-521','924604','3449','F','black     ','83492','N'),
('924611','Anton','Rajadurai','D2-821','252254','3450','F','black     ','83493','N'),
('924612','Jan','Postuma','B2-821','924611','3451','F','brown     ','83494','N'),
('924613','Lenuta','Quarishi','B1-821','924611','3452','F','black     ','83495','N'),
('924614','Christian','Mueller','C4-721','924611','3453','M','black     ','83496','N'),
('924615','Judy','Woolridge','C3-717','924611','3454','F','brown     ','83497','N'),
('924616','Rizalino','Espiritu','C3-727','924611','3455','M','brown     ','83498','N'),
('924617','Mark','Smiley','C3-723','924611','3456','M','grey      ','83499','Y'),
('924618','Alan','Pang','A3-323','252254','3456','M','grey      ','83500','Y'),
('924619','Ye','Zhang','A3-317','924618','3457','M','grey      ','83501','N'),
('924620','Mary','Hostetler','A3-216','924618','3458','F','grey      ','83502','N'),
('924621','Carolyn','Maloney','B3-216','924618','3459','F','brown     ','83503','N'),
('924622','CHEN','QING','B1-416','924618','3460','M','black     ','83504','N'),
('924623','Wei','Hong','C1-436','924618','3461','F','black     ','83505','N'),
('924624','Alfred','Chan','C1-436','924618','3462','M','black     ','83506','N'),
('924627','Thirugnan sambandham','Venkatachalam','D2-536','924625','3465','M','black     ','83509','N'),
('924628','Xudong','Gu','D2-436','924625','3466','M','black     ','83510','N'),
('924629','Gregor','Baguhin','D3-431','924625','3467','M','white     ','83511','N'),
('924630','David','Da Rosa','A3-431','924625','3468','M','white     ','83512','N'),
('924631','J','Meek','A3-421','924625','3468','M','brown     ','83513','Y'),
('924632','Hong','Li','A4-821','262745','3469','M','black     ','83514','N'),
('924633','Guobin','Yin','B4-821','924632','3470','M','black     ','83515','N'),
('924634','Francis','LeBlanc','B4-321','924632','3471','M','black     ','83516','N'),
('924635','Jenny','Wang','B1-921','924632','3472','F','black     ','83517','Y'),
('924636','Xin','Fang','C1-921','924632','3472','M','black     ','83518','N'),
('924637','Dwight','Balser Balser','C3-925','924632','3473','M','blonde    ','83519','N'),
('924638','Shuwei','Wang','C4-125','924632','3474','F','black     ','83520','N'),
('924639','Prasad','Rao','B4-125','262745','3476','M','black     ','83521','N'),
('924640','Trevor','Hancheroff','B2-120','924639','3477','M','brown     ','83522','N'),
('924641','Hima','Yajnik','B4-320','924639','3478','M','brown     ','83523','N'),
('924642','Sander','Campo Dall Orto','B3-320','924639','3479','M','brown     ','83524','N'),
('924643','Cristiano','Stupp','D3-320','924639','3480','M','brown     ','83525','N'),
('924644','Ron','Baba','D3-420','924639','3481','M','grey      ','83526','N'),
('924645','Umberto','Azevedo','D2-420','924639','3483','M','grey      ','83527','N'),
('924646','Cristina','Doi','A2-420','262745','3484','F','grey      ','83528','N'),
('924647','Leila','Oliveira','A2-510','924646','3485','F','grey      ','83529','N'),
('924648','Gillian','Close','B2-510','924646','3486','F','brown     ','83530','N'),
('924649','Terrie','Starling','C2-610','924646','3487','F','blonde    ','83531','N'),
('924650','Silvia','Cunha','C2-617','924646','3488','F','black     ','83532','N'),
('924651','Francisco','Ge?filo','C4-617','924646','3489','M','black     ','83533','N'),
('924652','Rogerio','Coelho','A4-617','924646','3490','M','brown     ','83534','Y'),
('924653','Scott','Walker','A1-617','262745','3491','M','brown     ','83535','Y'),
('924654','Tara-Lee','Tracy','A1-817','924653','3492','F','brown     ','83536','N'),
('924655','Barry','Onizak','C1-817','924653','3493','M','black     ','83537','N'),
('924656','Perry','McKenzie','C2-817','924653','3494','M','black     ','83538','N'),
('924657','Gang','Mei','C2-217','924653','3495','M','black     ','83539','N'),
('924658','Kenan','Meng','C2-216','924653','3496','M','black     ','83540','N'),
('924659','Daljit','Chima','D3-216','924653','3497','M','black     ','83541','N'),
('924660','Christopher','Wing','D2-213','262745','3498','M','black     ','83542','N'),
('924661','Bill','Smith','D4-213','924660','3499','M','blonde    ','83543','N'),
('924662','James','Scott','B4-213','924660','3500','M','grey      ','83544','N'),
('924663','Yajie','Jiang','B2-213','924660','3501','M','black     ','83545','N'),
('924664','George','Hanson','B1-213','924660','3502','M','black     ','83546','N'),
('924665','Stephen','Roberts','B1-214','924660','3503','M','black     ','83547','N'),
('924666','James','Chung','A1-214','924660','3504','M','black     ','83548','N'),
('924667','Luciana','Alves','A3-214','278354','3505','F','brown     ','83549','N'),
('924668','Peter','Sullivan','A3-814','924667','3506','M','brown     ','83550','N'),
('924669','David','Stephenson','D3-814','924667','3507','M','brown     ','83551','N'),
('924670','Neal','Yeung','D4-814','924667','3508','M','brown     ','83552','N'),
('924671','Dipika','Grewal','D4-714','924667','3510','F','black     ','83553','N'),
('924672','Anne','Mamye','D1-714','924667','3511','F','black     ','83554','N'),
('924673','Arvind','Prasad','B1-714','924667','3512','F','black     ','83555','N'),
('924674','Dipika','Grewal','C2-714','278354','3513','F','black     ','83556','N'),
('924675','Ida','Tober','C3-714','924674','3514','F','brown     ','83557','Y'),
('924676','Sik Man','Lo','C3-114','924674','3516','M','black     ','83558','N'),
('924677','Michael','Chittick','C1-114','924674','3517','M','grey      ','83559','N'),
('924678','Matt','Stephenson','B1-114','924674','3518','M','blonde    ','83560','N'),
('924679','Vigen','Ngo','B3-214','924674','3520','M','black     ','83561','N'),
('924680','Andrew','Chua','A3-214','924674','3521','M','black     ','83562','N'),
('924681','Sreeni','Pendyala','A2-214','278354','3523','F','black     ','83563','N'),
('924682','Brad','Cavanagh','C2-414','924681','3524','M','brown     ','83564','N'),
('924683','Zdravko','Martchev','C2-424','924681','3525','M','brown     ','83565','N'),
('924684','Dong','Li','C3-424','924681','3526','M','black     ','83566','N'),
('924685','Dong','Li','C3-324','924681','3527','M','black     ','83567','N'),
('924686','James','Brooks','D3-324','924681','3528','M','brown     ','83568','N'),
('924687','Jaan','Laansoo','D3-334','924681','3529','M','brown     ','83569','N'),
('924689','Douglas','Campbell','A3-334','278354','3529','M','black     ','83571','N'),
('924690','Catherine','Yeung','A4-134','924689','3530','M','black     ','83572','N'),
('924691','Zelda','Jeger','A1-134','924689','3531','F','black     ','83573','N'),
('924692','Chris','Dufour','A1-132','924689','3532','M','brown     ','83574','N'),
('924693','Dashan','Zhao','B1-132','924689','3533','M','brown     ','83575','N'),
('924694','Andrew','Pham','C1-132','924689','3534','M','black     ','83576','N'),
('924695','Marla','Mangaser','D4-132','924689','3535','F','black     ','83577','N'),
('924696','Chou Wee','Tee','D3-132','924689','3536','M','black     ','83578','N');

INSERT INTO lobby (first_name, last_name, badge_number) VALUES 
('Tuan','Ong','V0058'),
('Shahreyar','Qadir','V0059'),
('Peter','Wong','V0060'),
('T.','Kreysel','V0061'),
('Srinivasan','Raju','V0062'),
('Hong','Bao','V0063'),
('Zhichang','Liang','V0064'),
('Frank','Bergemann','V0065'),
('Eric','Herber','V0066'),
('Friedemann','Schwenkreis','V0067');

INSERT INTO hardware (employee_id, location, hardware_tn, hardware_sn) VALUES 
('534373','B3-268','7897-897','23-78234'),
('73732 ','C2-762','7897-897','78-23672'),
('897575','C2-123','3497-845','56-23622'),
('262745','A4-324','3487-845','58-22352'),
('629832','A2-462','3287-845','67-23452'),
('847254','A1-422','3287-845','67-23232'),
('252254','B3-252','5687-845','34-24232'),
('243354','B4-222','5587-845','34-22332'),
('278354','B1-772','2387-845','34-24332'),
('893454','C1-742','2387-845','34-24331'),
('893445','C1-734','2387-845','34-24336'),
('234445','D1-734','2387-545','34-66336'),
('823474','D2-736','2317-545','34-66246'),
('825474','D3-536','2327-545','67-66246'),
('673574','D2-524','2327-545','67-66566'),
('673774','C2-524','9327-545','67-68886'),
('257674','C2-784','9527-545','23-68886'),
('983674','C2-484','9527-445','23-69486'),
('924574','C2-554','9527-445','73-69346'),
('924575','B2-554','9537-445','73-69347'),
('924576','B2-654','6637-445','73-69265'),
('924577','B3-644','6637-425','74-69265'),
('924578','B3-454','6627-425','74-22265'),
('924579','D3-294','6627-295','74-22765'),
('924580','D1-294','6628-295','74-22665'),
('924581','D1-283','6628-295','74-22385'),
('924582','A3-273','6628-295','34-56385'),
('924583','B3-273','5628-295','54-56325'),
('924584','B3-123','5629-295','54-52355'),
('924585','B4-143','5625-295','54-52255'),
('924586','C4-143','5725-295','54-58255'),
('924587','C1-223','5745-295','54-58256'),
('924588','C1-563','5745-295','54-57956'),
('924589','C1-593','6745-295','55-57926'),
('924590','C4-533','6745-295','95-87931'),
('924591','C3-453','6745-295','95-87981'),
('924592','B3-783','6745-295','95-89983'),
('924593','B3-663','7832-265','23-89483'),
('924594','D3-653','7842-265','43-89453'),
('924595','D2-653','7352-265','43-89267'),
('924596','D2-648','7352-265','43-82356'),
('924597','A2-248','7352-285','43-82378'),
('924598','A4-247','7352-245','43-82783'),
('924599','A1-238','7352-245','43-88732'),
('924600','B2-738','6352-291','43-89762'),
('924601','B3-718','6352-291','43-81492'),
('924602','B3-713','8523-291','71-81494'),
('924603','C3-712','8543-291','91-82374'),
('924604','C4-312','8543-292','91-82773'),
('924605','C4-213','8543-232','91-82774'),
('924606','B4-213','9553-232','96-82774'),
('924607','B3-223','9543-232','96-82684'),
('924608','A1-623','9543-232','96-82687'),
('924609','A1-523','3443-232','96-82457'),
('924610','D1-521','3443-232','96-87357'),
('924611','D2-821','3123-232','16-87358'),
('924612','B2-821','3123-252','16-87335'),
('924613','B1-821','4723-252','16-87337'),
('924614','C4-721','4723-252','16-92375'),
('924615','C3-717','4725-252','16-92332'),
('924616','C3-727','4725-232','46-92358'),
('924617','C3-723','4725-232','46-83448'),
('924618','A3-323','4725-232','45-83668'),
('924619','A3-317','4775-232','45-87879'),
('924620','A3-216','4775-232','45-87822'),
('924621','B3-216','4675-232','45-87868'),
('924622','B1-416','4655-232','45-87561'),
('924623','C1-436','4655-232','45-83261'),
('924624','C1-436','4655-232','45-83263'),
('924625','C2-466','4655-232','75-71863'),
('924626','C2-536','4655-232','75-71846'),
('924627','D2-536','4655-292','75-75762'),
('924628','D2-436','4655-292','75-45814'),
('924629','D3-431','4655-292','75-45893'),
('924630','A3-431','4655-292','76-45893'),
('924631','A3-421','4655-291','89-45896'),
('924632','A4-821','4655-291','89-45228'),
('924633','B4-821','4855-234','89-46128'),
('924634','B1-321','4855-234','29-45128'),
('924635','B1-921','4855-234','29-45173'),
('924636','C1-921','9255-234','29-45725'),
('924637','C1-925','9254-234','29-45675'),
('924638','C4-125','9254-264','29-45672'),
('924639','B4-125','1254-264','39-45642'),
('924640','B2-120','1254-264','39-45679'),
('924641','B4-320','1254-264','39-45682'),
('924642','B3-320','1254-264','39-45681'),
('924643','D3-320','9654-264','39-49181'),
('924644','D3-420','9654-264','39-42781'),
('924645','D2-420','1054-264','39-42745'),
('924646','A2-420','1054-264','39-42622'),
('924647','A2-510','1024-264','39-42636'),
('924648','B2-510','1024-264','48-42636'),
('924649','C2-610','1024-672','48-42446'),
('924650','C2-617','1024-672','48-52346'),
('924651','C4-617','2224-672','88-52746'),
('924652','A4-617','2224-673','88-52735'),
('924653','A1-617','2224-673','81-52732'),
('924654','A1-817','2224-673','81-52412'),
('924655','C1-817','2224-673','81-53312'),
('924656','C2-817','2224-673','81-53747'),
('924657','C2-217','2324-673','81-53751'),
('924658','C2-216','2324-673','81-53341'),
('924659','D3-216','6424-673','81-53932'),
('924660','D2-213','6354-673','61-53522'),
('924661','D4-213','6354-673','61-82512'),
('924662','B4-213','6354-673','61-82392'),
('924663','B2-213','6924-673','61-84522'),
('924664','B1-213','6924-673','61-14362'),
('924665','B1-214','1182-673','37-14362'),
('924666','A1-214','1182-673','37-14252'),
('924667','A3-214','1182-673','37-12592'),
('924668','A3-814','1182-673','37-12537'),
('924669','D3-814','1182-673','37-61537'),
('924670','D4-814','1182-673','37-61237'),
('924671','D4-714','1182-673','37-61268'),
('924672','D1-714','1182-673','37-61338'),
('924673','B1-714','1282-673','37-61335'),
('924674','C2-714','1282-673','37-61813'),
('924675','C3-714','1281-673','37-62213'),
('924676','C3-114','2281-673','37-62234'),
('924677','C1-114','2281-673','42-62235'),
('924678','B1-114','2281-483','42-62475'),
('924679','B3-214','2281-483','42-62263'),
('924680','A3-214','2281-483','42-62933'),
('924681','A2-214','2381-483','73-62973'),
('924682','C2-414','2381-483','73-62992'),
('924683','C2-424','2381-483','73-37992'),
('924684','C3-424','2381-483','73-37991'),
('924685','C3-324','5381-483','23-37611'),
('924686','D3-324','5381-483','23-37613'),
('924687','D3-334','5381-483','23-37643'),
('924689','A3-334','5231-483','23-37889'),
('924690','A4-134','5231-483','23-37890'),
('924691','A1-134','5231-483','23-37891'),
('924692','A1-132','5231-483','23-37892'),
('924693','B1-132','5231-483','23-37893'),
('924694','C1-132','5231-483','23-37894'),
('924695','D4-132','5231-483','23-37895'),
('924696','D3-132','5231-483','23-37896');