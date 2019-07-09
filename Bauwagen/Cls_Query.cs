using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bauwagen
{ 
    class Cls_Query
    {
        #region Objekte für Anwender neu erstellen
        public static string DropTableNamen()
        {
            string sQuery = "";

            sQuery = "DROP TABLE personen\n";

            return sQuery;
        }

        public static string CreateTableNamen()
        {
            string sQuery = "";

            sQuery = "CREATE TABLE personen (\n";
            sQuery += "    id           NUMBER PRIMARY KEY,\n";
            sQuery += "    vorname      VARCHAR2(50) NOT NULL,\n";
            sQuery += "    name         VARCHAR2(50) NOT NULL,\n";
            sQuery += "    password     VARCHAR2(50) NOT NULL,\n";
            sQuery += "    last_logon   DATE DEFAULT SYSDATE NOT NULL ,\n";
            sQuery += "    locked       NUMBER DEFAULT 0 NOT NULL ,\n";
            sQuery += "    bad_logon    NUMBER DEFAULT 0 NOT NULL ,\n";
            sQuery += "    lock_date    DATE,\n";
            sQuery += "    kredit       NUMBER,\n";
            sQuery += "    change_pw    NUMBER DEFAULT 0,\n";
            sQuery += "    token_id     VARCHAR2(100),\n";
            sQuery += "    budget       NUMBER)\n";

            return sQuery;
        }

        public static string DropSequenceUserID()
        {
            string sQuery = "";

            sQuery = "DROP SEQUENCE SEQ_USER_ID\n";

            return sQuery;
        }

        public static string CreateSequenceUserID()
        {
            string sQuery = "";

            sQuery = "CREATE SEQUENCE SEQ_USER_ID INCREMENT BY 1 START WITH 1 NOCACHE\n";

            return sQuery;
        }

        public static string DropTableGüterdaten()
        {
            string sQuery = "";

            sQuery = "DROP TABLE gueter\n";

            return sQuery;
        }

        public static string CreateTableGüter()
        {
            string sQuery = "";

            sQuery = "CREATE TABLE gueter (\n";
            sQuery += "    beschreibung VARCHAR2(50) NOT NULL,\n";
            sQuery += "    preis        NUMBER NOT NULL,\n";
            sQuery += "    gueltig_von  DATE DEFAULT SYSDATE NOT NULL,\n";
            sQuery += "    gueltig_bis  DATE,\n";
            sQuery += "    last_update  DATE DEFAULT SYSDATE NOT NULL ,\n";
            sQuery += "    locked       NUMBER DEFAULT 0 NOT NULL ,\n";
            sQuery += "    lock_date    DATE)\n";

            return sQuery;
        }

        public static string CreateTableHistory()
        {
            string sQuery = "";

            sQuery = "CREATE TABLE HISTORY\n";
            sQuery += "(\n";
            sQuery += "  ID_USER NUMBER NOT NULL\n";
            sQuery += ", BESCHREIBUNG VARCHAR2(100)\n";
            sQuery += ", ANZAHL NUMBER\n";
            sQuery += ", EINZEL_PREIS NUMBER\n";
            sQuery += ", SUMME NUMBER\n";
            sQuery += ", DATUM_UHR DATE DEFAULT SYSDATE NOT NULL\n";
            sQuery += ")\n";

            return sQuery;
        }

        public static string CreateTableAufladungen()
        {
            string sQuery = "";

            sQuery = "CREATE TABLE AUFLADUNG\n";
            sQuery += "(\n";
            sQuery += "  ID_USER NUMBER NOT NULL\n";
            sQuery += ", DATUM_UHR DATE DEFAULT SYSDATE NOT NULL\n";
            sQuery += ", BETRAG NUMBER NOT NULL\n";
            sQuery += ")\n";

            return sQuery;
        }
        #endregion

        public static string GetMaxAnderID()
        {
            string sQuery = "";

            sQuery = "SELECT count(id) FROM " + Frm_Haupt.sSchema + ".personen\n";

            return sQuery;
        }

        public static string GetAnwenderDaten(string sName)
        {
            string sQuery = "";

            sQuery = "SELECT id,\n";
            sQuery += "    vorname,\n";
            sQuery += "    name,\n";
            sQuery += "    password,\n";
            sQuery += "    last_logon,\n";
            sQuery += "    locked,\n";
            sQuery += "    bad_logon,\n";
            sQuery += "    lock_date,\n";
            sQuery += "    nvl(budget,0),\n";
            sQuery += "    nvl(kredit,0),\n";
            sQuery += "    nvl(change_pw,1)\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".personen\n";

            if (sName != "")
            {
                sQuery += "WHERE vorname||' '||name = '" + sName + "'\n";
                sQuery += "    AND nvl(bad_logon,0) <= 5\n";
            }

            return sQuery;
        }

        public static string UpdateBadLogonAnwender(string sName, bool bLock, string sPassword)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";

            if (sPassword != "")
            {
                sQuery += "password = '" + sPassword + "',\n";
                sQuery += "change_pw = 0,\n";
            }

            if (bLock == false)
            {
                sQuery += "bad_logon = 0,\n";
                sQuery += "last_logon = SYSDATE\n";
            }
            else if (bLock == true)
            {
                sQuery += "bad_logon = bad_logon + 1,\n";
                sQuery += "last_logon = SYSDATE\n";
            }

            sQuery += "WHERE vorname||' '||name = '" + sName + "'\n";

            return sQuery;
        }

        public static string UpdateUserBudget(string sName, string sDelta)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";
            sQuery += "    budget = nvl(budget,0) - " + sDelta.Replace(",", ".") + "\n";
            sQuery += "WHERE vorname||' '||name = '" + sName + "'\n";

            return sQuery;
        }

        public static string InsertUser(string sName, string sVorname, string sPassword, string sBudget, string sKredit, string sTokenID, string sChangePW)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".personen\n";
            sQuery += "(id, vorname, name, password, budget, kredit, token_id, change_pw)\n";
            sQuery += "VALUES\n";
            sQuery += "(seq_user_id.nextval,\n";
            sQuery += "'" + sVorname + "',\n";
            sQuery += "'" + sName + "',\n";
            sQuery += "'" + sPassword + "',\n";
            sQuery += sBudget.Replace(",", ".") + ",\n";
            sQuery += sKredit.Replace(",", ".") + ",\n";
            sQuery += "'" + sTokenID + "',\n";
            sQuery += sChangePW + ")\n";

            return sQuery;
        }

        public static string UpdateUserAufladung(string sName, string sDelta)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";
            sQuery += "    budget = nvl(budget,0) + " + sDelta.Replace(",", ".") + "\n";
            sQuery += "WHERE vorname||' '||name = '" + sName + "'\n";

            return sQuery;
        }

        public static string GetMaxGüterID()
        {
            string sQuery = "";

            sQuery = "SELECT count(beschreibung) FROM " + Frm_Haupt.sSchema + ".gueter\n";

            return sQuery;
        }

        public static string GetGüterDaten(string sBeschreibung)
        {
            string sQuery = "";

            sQuery = "SELECT beschreibung,\n";
            sQuery += "    preis,\n";
            sQuery += "    gueltig_von,\n";
            sQuery += "    gueltig_bis,\n";
            sQuery += "    last_update,\n";
            sQuery += "    locked,\n";
            sQuery += "    lock_date\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".gueter\n";
            sQuery += "WHERE locked = 0\n";
            sQuery += "    AND SYSDATE BETWEEN gueltig_von AND nvl(gueltig_bis,SYSDATE+1)\n";

            if (sBeschreibung != "")
            {
                sQuery += "    AND beschreibung = '" + sBeschreibung + "'\n";
            }

            return sQuery;
        }

        public static string InsertHistory(string sName, string sItem, string sAnzahl, string sEinzelpreis, string sSumme)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".history\n";
            sQuery += "(id_user, beschreibung, anzahl, einzel_preis, summe, datum_uhr)\n";
            sQuery += "VALUES\n";
            sQuery += "((SELECT id FROM " + Frm_Haupt.sSchema + ".personen WHERE vorname||' '||name = '" + sName + "'),\n";
            sQuery += "'" + sItem + "',\n";
            sQuery += sAnzahl + ",\n";
            sQuery += sEinzelpreis.Replace(",", ".") + ",\n";
            sQuery += sSumme.Replace(",", ".") + ",\n";
            sQuery += "SYSDATE)\n";

            return sQuery;
        }

        public static string InsertAufladung(string sName, string sBetrag)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".aufladung\n";
            sQuery += "(id_user, datum_uhr, betrag)\n";
            sQuery += "VALUES\n";
            sQuery += "((SELECT id FROM " + Frm_Haupt.sSchema + ".personen WHERE vorname||' '||name = '" + sName + "'),\n";
            sQuery += "SYSDATE,\n";
            sQuery += sBetrag.Replace(",", ".") + ")\n";

            return sQuery;
        }

    }
}
