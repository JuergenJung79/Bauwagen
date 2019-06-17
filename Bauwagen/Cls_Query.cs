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
            sQuery += "    nvl(budget,0)\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".personen\n";

            if (sName != "")
            {
                sQuery += "WHERE vorname||' '||name = '" + sName + "'\n";
                sQuery += "    AND nvl(bad_logon,0) <= 5\n";
            }

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

        public static string UpdateBadLogonAnwender(string sName, bool bLock)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";

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
    }
}
