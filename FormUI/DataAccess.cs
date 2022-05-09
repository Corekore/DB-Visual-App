using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

// we get information out of sql server
namespace FormUI
{
    public class DataAccess
    {
        // DATA ACCESS FOR CLIENT
        public List<Client> GetInfo1() //get info 1 personanele care au lucrat cu mai mult de un angajat
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"select A.Nume, A.Prenume from profilClient A inner join profilAngajat B ON A.CLIENTID = B.CLIENTID group by A.Nume, A.Prenume Having count(A.CLIENTID) > 1").ToList();
            }
        }
        public List<Client> GetInfo2() //get info 2 persoanele care au mai mult de doua contracte
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"select A.Nume, A.Prenume from profilClient A inner join istoricContracte B ON A.CLIENTID = B.CLIENTID group by A.Nume, A.Prenume having count(A.CLIENTID) > 2").ToList();
            }
        }
        public List<Client> GetInfo4() //get info 4 numele clientilor in ordine descrescatoare dupa numarul de angajati
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"SELECT D.Nume, D.Prenume FROM profilAngajat P INNER JOIN profilClient D  ON D.clientID = P.clientID group by D.Nume, D.Prenume ORDER BY count(D.clientID) DESC").ToList();
            }
        }
        public List<Client> GetInfo5() //get info 5 numele clientilor in ordine descrescatoare dupa numarul de contracte
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"SELECT D.Nume, D.Prenume FROM istoricContracte P INNER JOIN profilClient D  ON D.clientID = P.clientID group by D.Nume, D.Prenume ORDER BY count(D.clientID) DESC").ToList();
            }
        }
        public List<Client> GetInfo6() //get info 6 numele clientilor care au depus atestat de la registrul comertului
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"SELECT D.Nume, D.Prenume FROM documenteOficiale P INNER JOIN profilClient D  ON D.documenteid = P.documenteid where P.ARC = 'da' group by D.Nume, D.Prenume").ToList();
            }
        }
        public List<Client> GetClientByName(string Nume) //get client by name
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"select * from profilClient where Nume = '{ Nume }'").ToList();
            }
        }
        public List<Client> GetClient() //get all client
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<Client>($"select * from profilClient").ToList();
            }
        }
        public void DeleteClient(int clientid) //delete client
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                connection.Execute($"delete from profilClient where CLIENTID = '{ clientid }'");
                
            }
        }
        //insert client
        internal void InsertClient(int clientid, int reprezentantid, string nume, string prenume, string cnp, string strada, string numar, string oras, string sex, string datanasterii)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                //Client newclient = new Client { Nume = nume, Prenume = prenume, CNP = cnp, Strada = strada, Numar = numar, Oras = oras, Sex = sex, DataNasterii = datanasterii };
                List<Client> client = new List<Client>();
                client.Add(new Client { CLIENTID = clientid, REPREZENTANTID = reprezentantid,Nume = nume, Prenume = prenume, CNP = cnp, Strada = strada, Numar = numar, Oras = oras, Sex = sex, DataNasterii = datanasterii });

                connection.Execute($"insert into profilClient (CLIENTID, REPREZENTANTID, Nume, Prenume, CNP, Strada, Numar, Oras, Sex, DataNasterii) values ('{ clientid }', '{ reprezentantid }', '{ nume }', '{ prenume }', '{ cnp }', '{ strada }', '{ numar }', '{ oras }', '{ sex }', '{ datanasterii }')");
            }
        }
        
        //update client
        internal void UpdateClient (int clientid, int reprezentantid, string nume, string prenume, string cnp, string strada, string numar, string oras, string sex, string datanasterii)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                List<Client> client = new List<Client>();
                client.Add(new Client { CLIENTID = clientid, REPREZENTANTID = reprezentantid, Nume = nume, Prenume = prenume, CNP = cnp, Strada = strada, Numar = numar, Oras = oras, Sex = sex, DataNasterii = datanasterii });
                connection.Execute($"update profilClient set CLIENTID = '{ clientid }', REPREZENTANTID = '{ reprezentantid }', Nume = '{ nume }', Prenume = '{ prenume }', CNP = '{ cnp }', Strada = '{ strada }', Numar = '{ numar }', Oras = '{ oras }', Sex = '{ sex }', DataNasterii = '{ datanasterii }' where CLIENTID = '{ clientid }'");
            }
        }
        // DATA ACCESS FOR ANGAJAT

        public List<AngajatShow> GetAngajat() //get all angajat
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<AngajatShow>($"select * from profilAngajat").ToList();
            }
        }
        // insert angajat
        internal void InsertAngajat(int angajatid, string nume, string prenume, int clientid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                
                List<AngajatShow> angajat = new List<AngajatShow>();
                angajat.Add(new AngajatShow { ANGAJATID = angajatid, Nume = nume, Prenume = prenume, CLIENTID = clientid });

                connection.Execute($"insert into profilAngajat (ANGAJATID, Nume, Prenume, CLIENTID) values ('{ angajatid }', '{ nume }', '{ prenume }', '{ clientid }')");
            }
        }
        public void DeleteAngajat(int angajatid) //delete angajat
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                connection.Execute($"delete from profilAngajat where AngajatID = '{ angajatid }'");

            }
        }

        //update angajat
        internal void UpdateAngajat(int angajatid, string nume, string prenume, int clientid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {

                List<AngajatShow> angajat = new List<AngajatShow>();
                angajat.Add(new AngajatShow { ANGAJATID = angajatid, Nume = nume, Prenume = prenume, CLIENTID = clientid });

                connection.Execute($"update profilAngajat set ANGAJATID = '{ angajatid }', Nume = '{ nume }', Prenume = '{ prenume }', CLIENTID = '{ clientid }' where ANGAJATID = '{ angajatid }'");
            }
        }
        // DATA ACCESS FOR REPREZENTANT

        public List<ReprezentantShow> GetInfo3() //get info 3 --persoanele care sunt reprezentant pentru mai multi clienti
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<ReprezentantShow>($"select B.Nume, B.Prenume from profilClient A inner join profilReprezentant B ON A.REPREZENTANTID = B.REPREZENTANTID group by B.Nume, B.Prenume having count(B.REPREZENTANTID) > 1").ToList();
            }
        }

        public List<ReprezentantShow> GetReprezentant() //get all reprezentant
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<ReprezentantShow>($"select * from profilReprezentant").ToList();
            }
        }
        // insert angajat
        internal void InsertReprezentant(int reprezentantid, string nume, string prenume, string cnp, string strada, string numar, string oras, string sex, string datanasterii)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                //Client newclient = new Client { Nume = nume, Prenume = prenume, CNP = cnp, Strada = strada, Numar = numar, Oras = oras, Sex = sex, DataNasterii = datanasterii };
                List<ReprezentantShow> reprezentant = new List<ReprezentantShow>();
                reprezentant.Add(new ReprezentantShow { REPREZENTANTID = reprezentantid, Nume = nume, Prenume = prenume, CNP = cnp, Strada = strada, Numar = numar, Oras = oras, Sex = sex, DataNasterii = datanasterii });

                connection.Execute($"insert into profilReprezentant (REPREZENTANTID, Nume, Prenume, CNP, Strada, Numar, Oras, Sex, DataNasterii) values ('{ reprezentantid }', '{ nume }', '{ prenume }', '{ cnp }', '{ strada }', '{ numar }', '{ oras }', '{ sex }', '{ datanasterii }')");
            }
        }
        public void DeleteReprezentant(int reprezentantid) //delete reprezentant
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                connection.Execute($"delete from profilReprezentant where REPREZENTANTID = '{ reprezentantid }'");

            }
        }

        // DATA ACCESS FOR Documente
        public List<DocumenteShow> GetDocumente() //get all documente
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<DocumenteShow>($"select * from documenteOficiale").ToList();
            }
        }
        // insert documente
        internal void InsertDocumente(int documenteid, string buletin, string arc, string actejuridice, string adeverintasalariat, string contractangajator, string alteacte)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {

                List<DocumenteShow> documente = new List<DocumenteShow>();
                documente.Add(new DocumenteShow { DOCUMENTEID = documenteid, Buletin = buletin, ARC = arc, ActeJuridice = actejuridice, AdeverintaSalariat = adeverintasalariat, ContractAngajator = contractangajator, AlteActe = alteacte});

                connection.Execute($"insert into documenteOficiale (DOCUMENTEID, Buletin, ARC, ActeJuridice, AdeverintaSalariat, ContractAngajator, AlteActe) values ('{ documenteid }', '{ buletin }', '{ arc }', '{ actejuridice }', '{ adeverintasalariat }', '{ contractangajator }', '{ alteacte }')");
            }
        }
        public void DeleteDocumente(int documenteid) //delete documente
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                connection.Execute($"delete from documenteOficiale where DOCUMENTEID = '{ documenteid }'");

            }
        }

        // DATA ACCESS FOR Istoric
        public List<IstoricShow> GetIstoric() //get all documente
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                return connection.Query<IstoricShow>($"select * from istoricContracte").ToList();
            }
        }
        // insert istoric
        internal void InsertIstoric(int contractid, int clientid, string tipcontract, string datadeschidere, string starecontract)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {

                List<IstoricShow> istoric = new List<IstoricShow>();
                istoric.Add(new IstoricShow { CONTRACTID = contractid, CLIENTID = clientid, TipContract = tipcontract, DataDeschidere = datadeschidere, StareContract = starecontract });

                connection.Execute($"insert into istoricContracte (CONTRACTID, CLIENTID, TipContract, DataDeschidere, StareContract) values ('{ contractid }', '{ clientid }', '{ tipcontract }', '{ datadeschidere }', '{ starecontract }')");
            }
        }
        public void DeleteIstoric(int contractid) //delete istoric
        {
            // connect to sql server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BancaDB")))
            {
                connection.Execute($"delete from istoricContracte where CONTRACTID = '{ contractid }'");

            }
        }
    }
}
