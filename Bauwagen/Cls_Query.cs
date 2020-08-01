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
            sQuery += "    id           NUMBER,\n";
            sQuery += "    vorname      VARCHAR2(50) NOT NULL,\n";
            sQuery += "    password     VARCHAR2(50) NOT NULL,\n";
            sQuery += "    last_logon   DATE DEFAULT SYSDATE NOT NULL ,\n";
            sQuery += "    locked       NUMBER DEFAULT 0 NOT NULL ,\n";
            sQuery += "    bad_logon    NUMBER DEFAULT 0 NOT NULL ,\n";
            sQuery += "    lock_date    DATE,\n";
            sQuery += "    budget       NUMBER,\n";
            sQuery += "    kredit       NUMBER,\n";
            sQuery += "    change_pw    NUMBER DEFAULT 0,\n";
            sQuery += "    token_id     VARCHAR2(100),\n";
            sQuery += "  CONSTRAINT PK_VORNAME PRIMARY KEY\n";
            sQuery += "    (\n";
            sQuery += "      id\n";
            sQuery += "    )\n";
            sQuery += "    ENABLE )\n";

            return sQuery;
        }

        public static string AddUniqueConstraintPersonen()
        {
            string sQuery = "";

            sQuery = "ALTER TABLE personen\n";
            sQuery += "ADD CONSTRAINT UK_ID UNIQUE\n";
            sQuery += "(\n";
            sQuery += "    vorname\n";
            sQuery += ")\n";
            sQuery += "ENABLE\n";

            return sQuery;
        }

        public static string DropSequenceUserID()
        {
            string sQuery = "";

            sQuery = "DROP SEQUENCE SEQ_USER_ID\n";

            return sQuery;
        }

        public static string CreateSequenceUserID(string sStartWith)
        {
            string sQuery = "";

            sQuery = "CREATE SEQUENCE SEQ_USER_ID INCREMENT BY 1 START WITH " + sStartWith + " NOCACHE\n";

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
            sQuery += "    lock_date    DATE,\n";
            sQuery += "  CONSTRAINT PK_BESCHREIBUNG PRIMARY KEY\n";
            sQuery += "    (\n";
            sQuery += "      beschreibung\n";
            sQuery += "    )\n";
            sQuery += "    ENABLE )\n";

            return sQuery;
        }

        public static string DropTableHistorydaten()
        {
            string sQuery = "";

            sQuery = "DROP TABLE history\n";

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

        public static string AddForeignKeyHistory()
        {
            string sQuery = "";

            sQuery = "ALTER TABLE HISTORY\n";
            sQuery += "ADD CONSTRAINT FK_BESCHREIBUNG FOREIGN KEY\n";
            sQuery += "(\n";
            sQuery += "    BESCHREIBUNG\n";
            sQuery += ")\n";
            sQuery += "REFERENCES GUETER\n";
            sQuery += "(\n";
            sQuery += "    BESCHREIBUNG\n";
            sQuery += ")\n";
            sQuery += "ENABLE\n";

            return sQuery;
        }

        public static string DropTableAufladungen()
        {
            string sQuery = "";

            sQuery = "DROP TABLE aufladung\n";

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

        public static string AddForeignKeyAufladungen()
        {
            string sQuery = "";

            sQuery = "ALTER TABLE AUFLADUNG\n";
            sQuery += "ADD CONSTRAINT FK_USER FOREIGN KEY\n";
            sQuery += "(\n";
            sQuery += "    ID_USER\n";
            sQuery += ")\n";
            sQuery += "REFERENCES PERSONEN\n";
            sQuery += "(\n";
            sQuery += "    ID\n";
            sQuery += ")\n";
            sQuery += "ENABLE\n";

            return sQuery;
        }

        public static string DropTableCocktails()
        {
            string sQuery = "";

            sQuery = "DROP TABLE COCKTAILS\n";

            return sQuery;
        }

        public static string CreateTableCocktails()
        {
            string sQuery = "";

            sQuery = "CREATE TABLE COCKTAILS\n";
            sQuery += "(\n";
            sQuery += "  NAME VARCHAR2(200)\n";
            sQuery += ", ZUTAT_01 VARCHAR2(50)\n";
            sQuery += ", DAUER_01_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_01_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_01_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_01_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_01_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_01_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_02 VARCHAR2(50)\n";
            sQuery += ", DAUER_02_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_02_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_02_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_02_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_02_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_02_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_03 VARCHAR2(50)\n";
            sQuery += ", DAUER_03_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_03_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_03_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_03_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_03_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_03_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_04 VARCHAR2(50)\n";
            sQuery += ", DAUER_04_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_04_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_04_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_04_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_04_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_04_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_05 VARCHAR2(50)\n";
            sQuery += ", DAUER_05_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_05_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_05_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_05_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_05_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_05_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_06 VARCHAR2(50)\n";
            sQuery += ", DAUER_06_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_06_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_06_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_06_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_06_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_06_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_07 VARCHAR2(50)\n";
            sQuery += ", DAUER_07_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_07_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_07_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_07_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_07_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_07_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_08 VARCHAR2(50)\n";
            sQuery += ", DAUER_08_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_08_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_08_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_08_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_08_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_08_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_09 VARCHAR2(50)\n";
            sQuery += ", DAUER_09_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_09_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_09_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_09_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_09_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_09_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_10 VARCHAR2(50)\n";
            sQuery += ", DAUER_10_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_10_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_10_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_10_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_10_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_10_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_11 VARCHAR2(50)\n";
            sQuery += ", DAUER_11_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_11_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_11_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_11_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_11_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_11_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_12 VARCHAR2(50)\n";
            sQuery += ", DAUER_12_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_12_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_12_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_12_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_12_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_12_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_13 VARCHAR2(50)\n";
            sQuery += ", DAUER_13_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_13_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_13_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_13_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_13_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_13_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_14 VARCHAR2(50)\n";
            sQuery += ", DAUER_14_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_14_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_14_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_14_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_14_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_14_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_15 VARCHAR2(50)\n";
            sQuery += ", DAUER_15_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_15_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_15_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_15_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_15_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_15_GROSS_STARK NUMBER\n";
            sQuery += ", ZUTAT_16 VARCHAR2(50)\n";
            sQuery += ", DAUER_16_KLEIN_SCHWACH NUMBER\n";
            sQuery += ", DAUER_16_KLEIN_MITTEL NUMBER\n";
            sQuery += ", DAUER_16_KLEIN_STARK NUMBER\n";
            sQuery += ", DAUER_16_GROSS_SCHWACH NUMBER\n";
            sQuery += ", DAUER_16_GROSS_MITTEL NUMBER\n";
            sQuery += ", DAUER_16_GROSS_STARK NUMBER,\n";
            sQuery += "  CONSTRAINT PK_NAME PRIMARY KEY\n";
            sQuery += "    (\n";
            sQuery += "      NAME\n";
            sQuery += "    )\n";
            sQuery += "    ENABLE )\n";

            return sQuery;
        }
        #endregion

        public static string GetMaxAnderID()
        {
            string sQuery = "";

            sQuery = "SELECT count(id) FROM " + Frm_Haupt.sSchema + ".personen\n";

            return sQuery;
        }

        public static string GetAnwenderDaten(string sName, bool bAdmin)
        {
            string sQuery = "";

            sQuery = "SELECT id,\n";
            sQuery += "    vorname,\n";
            sQuery += "    NULL AS reserve,\n";
            sQuery += "    password,\n";
            sQuery += "    last_logon,\n";
            sQuery += "    locked,\n";
            sQuery += "    bad_logon,\n";
            sQuery += "    lock_date,\n";
            sQuery += "    nvl(budget,0),\n";
            sQuery += "    nvl(kredit,0),\n";
            sQuery += "    nvl(change_pw,1),\n";
            sQuery += "    token_id\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".personen\n";

            if (sName != "")
            {
                sQuery += "WHERE vorname = '" + sName + "'\n";

                if (bAdmin == false)
                {
                    sQuery += "    AND nvl(bad_logon,0) <= 5\n";
                }
            }
            else if (sName == "" && bAdmin == false)
            {
                sQuery += "WHERE nvl(bad_logon,0) <= 5\n";
            }

            sQuery += "ORDER BY vorname\n";

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

            sQuery += "WHERE vorname = '" + sName + "'\n";

            return sQuery;
        }

        public static string UpdateUserBudget(string sName, string sDelta)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";
            sQuery += "    budget = nvl(budget,0) - " + sDelta.Replace(",", ".") + "\n";
            sQuery += "WHERE vorname = '" + sName + "'\n";

            return sQuery;
        }

        public static string InsertUser(bool bUpdate, string sVorname, string sPassword, string sBudget, string sKredit, string sTokenID, 
            string sChangePW, string sAktiv)
        {
            string sQuery = "";

            if (sAktiv == "0") { sAktiv = "10"; } else { sAktiv = "0"; }

            if (bUpdate == false)
            {
                sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".personen\n";
                sQuery += "(id, vorname, password, budget, kredit, token_id, change_pw, bad_logon)\n";
                sQuery += "VALUES\n";
                sQuery += "(seq_user_id.nextval,\n";
                sQuery += "'" + sVorname + "',\n";
                sQuery += "'" + sPassword + "',\n";
                sQuery += sBudget.Replace(",", ".") + ",\n";
                sQuery += sKredit.Replace(",", ".") + ",\n";
                sQuery += "'" + sTokenID + "',\n";
                sQuery += sChangePW + ",\n";
                sQuery += sAktiv + ")\n";
            }
            else
            {
                sQuery += "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";
                sQuery += "    password = '" + sPassword + "',\n";
                sQuery += "    budget = " + sBudget.Replace(",", ".") + ",\n";
                sQuery += "    kredit = " + sKredit.Replace(",", ".") + ",\n";
                sQuery += "    change_pw = " + sChangePW + ",\n";
                sQuery += "    token_id = '" + sTokenID + "',\n";
                sQuery += "    bad_logon = " + sAktiv + "\n";
                sQuery += "WHERE vorname = '" + sVorname + "'\n";
            }

            return sQuery;
        }

        public static string InsertUserRestore(string sVorname, string sPassword, string sLastlogon, string sLocked, string sBadLogon, string sLockDate, string sBudget,
            string sKredit, string sChangePassword, string sTokenID)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".personen\n";
            sQuery += "(id, vorname, password, last_logon, locked, bad_logon, lock_date, budget, kredit, change_pw, token_id)\n";
            sQuery += "VALUES\n";
            sQuery += "(seq_user_id.nextval,\n";
            sQuery += "'" + sVorname + "',\n";
            sQuery += "'" + sPassword + "',\n";

            if (sLastlogon != "")
            {
                sQuery += "to_date('" + sLastlogon + "','dd.mm.yyyy hh24:mi:ss'),\n";
            }
            else
            {
                sQuery += "NULL,\n";
            }

            sQuery += sLocked + ",\n";
            sQuery += sBadLogon + ",\n";

            if (sLockDate != "")
            {
                sQuery += "to_date('" + sLockDate + "','dd.mm.yyyy hh24:mi:ss'),\n";
            }
            else
            {
                sQuery += "NULL,\n";
            }

            sQuery += sBudget + ",\n";
            sQuery += sKredit + ",\n";
            sQuery += sChangePassword + ",\n";
            sQuery += "'" + sTokenID + "'\n";
            sQuery += ")\n";

            return sQuery;
        }

        public static string UpdateUserAufladung(string sName, string sDelta)
        {
            string sQuery = "";

            sQuery = "UPDATE " + Frm_Haupt.sSchema + ".personen SET\n";
            sQuery += "    budget = nvl(budget,0) + " + sDelta.Replace(",", ".") + "\n";
            sQuery += "WHERE vorname = '" + sName + "'\n";

            return sQuery;
        }

        public static string GetUserDashboardHistory(string sName, bool bDateFilter, string sDatumVon, string sDatumBis)
        {
            string sQuery = "";

            sDatumVon = sDatumVon.Substring(0, 10);
            sDatumBis = sDatumBis.Substring(0, 10);

            sQuery = "SELECT sum(a.summe),\n";
            sQuery += "    trunc(a.datum_uhr),\n";
            //sQuery += "    b.vorname,\n";
            sQuery += "    'Verbrauch'\n";
            sQuery += "FROM history a\n";
            sQuery += "JOIN personen b\n";
            sQuery += "    ON a.id_user = b.id\n";
            sQuery += "WHERE 1=1\n";

            if (sName != "") { sQuery += "    AND b.vorname = '" + sName + "'\n"; }
            if (bDateFilter == true) { sQuery += "    AND a.datum_uhr BETWEEN to_date('" + sDatumVon + "','dd.mm.yyyy') AND to_date('" + sDatumBis + "','dd.mm.yyyy')\n"; }

            sQuery += "GROUP BY trunc(a.datum_uhr),\n";
            sQuery += "    b.vorname\n";
            sQuery += "UNION\n";
            sQuery += "SELECT sum(a.betrag),\n";
            sQuery += "    trunc(a.datum_uhr),\n";
            //sQuery += "    b.vorname,\n";
            sQuery += "    'Aufladung'\n";
            sQuery += "FROM aufladung a\n";
            sQuery += "JOIN personen b\n";
            sQuery += "    ON a.id_user = b.id\n";
            sQuery += "WHERE 1=1\n";

            if (sName != "") { sQuery += "    AND b.vorname = '" + sName + "'\n"; }
            if (bDateFilter == true) { sQuery += "    AND a.datum_uhr BETWEEN to_date('" + sDatumVon + "','dd.mm.yyyy') AND to_date('" + sDatumBis + "','dd.mm.yyyy')\n"; }

            sQuery += "GROUP BY trunc(a.datum_uhr),\n";
            sQuery += "    b.vorname\n";

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

        public static string SaveGüterDaten(bool bInsert, bool bUpdate, string sBeschreibung, string sPreis, string sLocked)
        {
            string sQuery = "";

            if (bInsert == true && bUpdate == false)
            {
                sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".gueter\n";
                sQuery += "(beschreibung, preis, locked, gueltig_von, last_Update)\n";
                sQuery += "VALUES\n";
                sQuery += "('" + sBeschreibung + "',\n";
                sQuery += sPreis + ",\n";
                sQuery += sLocked + ",\n";
                sQuery += "SYSDATE,\n";
                sQuery += "SYSDATE)\n";
            }
            else if (bInsert == false && bUpdate == true)
            {
                sQuery = "UPDATE " + Frm_Haupt.sSchema + ".gueter SET\n";
                sQuery += "    preis = " + sPreis + ",\n";
                sQuery += "    locked = " + sLocked + ",\n";
                sQuery += "    last_update = SYSDATE\n";
                sQuery += "WHERE beschreibung = '" + sBeschreibung + "'\n";
            }


            return sQuery;
        }

        public static string InsertGüterRestore(string sBeschreibung, string sPreis, string sGueltig_von, string sGueltig_bis, string sLast_Update,
            string sLocked, string sLock_Date)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".gueter\n";
            sQuery += "(beschreibung, preis, gueltig_von, gueltig_bis, last_update, locked, lock_date)\n";
            sQuery += "VALUES\n";
            sQuery += "('" + sBeschreibung + "',\n";
            sQuery += sPreis + ",\n";

            if (sGueltig_von != "") { sQuery += "to_date('" + sGueltig_von + "','dd.mm.yyyy hh24:mi:ss'),\n"; } else { sQuery += "NULL,\n"; }
            if (sGueltig_bis != "") { sQuery += "to_date('" + sGueltig_bis + "','dd.mm.yyyy hh24:mi:ss'),\n"; } else { sQuery += "NULL,\n"; }
            if (sLast_Update != "") { sQuery += "to_date('" + sLast_Update + "','dd.mm.yyyy hh24:mi:ss'),\n"; } else { sQuery += "NULL,\n"; }
            sQuery += sLocked + ",\n";
            if (sLock_Date != "") { sQuery += "to_date('" + sLock_Date + "','dd.mm.yyyy hh24:mi:ss'))\n"; } else { sQuery += "NULL)\n"; }

            return sQuery;
        }

        public static string InsertHistory(string sName, string sItem, string sAnzahl, string sEinzelpreis, string sSumme)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".history\n";
            sQuery += "(id_user, beschreibung, anzahl, einzel_preis, summe, datum_uhr)\n";
            sQuery += "VALUES\n";
            sQuery += "((SELECT id FROM " + Frm_Haupt.sSchema + ".personen WHERE vorname = '" + sName + "'),\n";
            sQuery += "'" + sItem + "',\n";
            sQuery += sAnzahl + ",\n";
            sQuery += sEinzelpreis.Replace(",", ".") + ",\n";
            sQuery += sSumme.Replace(",", ".") + ",\n";
            sQuery += "SYSDATE)\n";

            return sQuery;
        }

        public static string InsertHistoryRestore(string sIDUser, string sBeschreibung, string sAnzahl, string sEinzelPreis, string sSumme, string sDatumUhr)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".history\n";
            sQuery += "(id_user, beschreibung, anzahl, einzel_preis, summe, datum_uhr)\n";
            sQuery += "VALUES\n";
            sQuery += "(" + sIDUser + ",\n";
            sQuery += "'" + sBeschreibung + "',\n";
            sQuery += sAnzahl + ",\n";
            sQuery += sEinzelPreis + ",\n";
            sQuery += sSumme + ",\n";
            if (sDatumUhr != "") { sQuery += "to_date('" + sDatumUhr + "','dd.mm.yyyy hh24:mi:ss'))\n"; } else { sQuery += "NULL)\n"; }

            return sQuery;
        }

        public static string GetHistoryDaten(string sName, string sDatumStart, string sDatumEnde)
        {
            string sQuery = "";

            sQuery = "SELECT id_user,\n";
            sQuery += "    beschreibung,\n";
            sQuery += "    anzahl,\n";
            sQuery += "    einzel_preis,\n";
            sQuery += "    summe,\n";
            sQuery += "    datum_uhr\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".history\n";
            sQuery += "WHERE 1=1\n";

            if (sName != "")
            {
                sQuery += "    AND id_user = (SELECT id " + Frm_Haupt.sSchema + ".personen WHERE vorname = '" + sName + "'),\n";
            }

            if (sDatumStart != "" && sDatumEnde != "")
            {
                sQuery += "    AND datum_uhr BETWEEN to_date('" + sDatumStart + "','dd.mm.yyyy') AND  to_date('" + sDatumEnde + "','dd.mm.yyyy')\n";
            }

            return sQuery;
        }

        public static string InsertAufladung(string sName, string sBetrag)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".aufladung\n";
            sQuery += "(id_user, datum_uhr, betrag)\n";
            sQuery += "VALUES\n";
            sQuery += "((SELECT id FROM " + Frm_Haupt.sSchema + ".personen WHERE vorname = '" + sName + "'),\n";
            sQuery += "SYSDATE,\n";
            sQuery += sBetrag.Replace(",", ".") + ")\n";

            return sQuery;
        }

        public static string InsertAufladungenRestore(string sIDUser, string sDatumUhr, string sBetrag)
        {
            string sQuery = "";

            sQuery = "INSERT INTO " + Frm_Haupt.sSchema + ".aufladung\n";
            sQuery += "(id_user, datum_uhr, betrag)\n";
            sQuery += "VALUES\n";
            sQuery += "(" + sIDUser + ",\n";
            if (sDatumUhr != "") { sQuery += "to_date('" + sDatumUhr + "','dd.mm.yyyy hh24:mi:ss'),\n"; } else { sQuery += "NULL,\n"; }
            sQuery += sBetrag + ")\n";

            return sQuery;
        }

        public static string GetAufladungDaten(string sName, string sDatumStart, string sDatumEnde)
        {
            string sQuery = "";

            sQuery = "SELECT id_user,\n";
            sQuery += "    datum_uhr,\n";
            sQuery += "    betrag\n";
            sQuery += "FROM " + Frm_Haupt.sSchema + ".aufladung\n";
            sQuery += "WHERE 1=1\n";

            if (sName != "")
            {
                sQuery += "    AND id_user = (SELECT id " + Frm_Haupt.sSchema + ".personen WHERE vorname = '" + sName + "'),\n";
            }

            if (sDatumStart != "" && sDatumEnde != "")
            {
                sQuery += "    AND datum_uhr BETWEEN to_date('" + sDatumStart + "','dd.mm.yyyy') AND  to_date('" + sDatumEnde + "','dd.mm.yyyy')\n";
            }

            return sQuery;
        }

        public static string GetUserHistory()
        {
            string sQuery = "";

            sQuery = "SELECT daten.vorname,\n";
            sQuery += "    daten.beschreibung,\n";
            sQuery += "    daten.anzahl,\n";
            sQuery += "    daten.datum_uhr,\n";
            sQuery += "    daten.einzel_preis,\n";
            sQuery += "    daten.summe\n";
            sQuery += "FROM (SELECT b.vorname,\n";
            sQuery += "        a.beschreibung,\n";
            sQuery += "        to_char(a.anzahl) AS anzahl,\n";
            sQuery += "        a.datum_uhr,\n";
            sQuery += "        to_char(a.einzel_preis) AS einzel_preis,\n";
            sQuery += "        a.summe\n";
            sQuery += "    FROM history a\n";
            sQuery += "    JOIN personen b\n";
            sQuery += "        ON a.id_user = b.id\n";
            //sQuery += "ORDER BY a.datum_uhr DESC\n";
            sQuery += "    UNION\n";
            sQuery += "    SELECT b.vorname,\n";
            sQuery += "        'Aufladung',\n";
            sQuery += "        '',\n";
            sQuery += "        a.datum_uhr,\n";
            sQuery += "        '',\n";
            sQuery += "        a.betrag\n";
            sQuery += "    FROM aufladung a\n";
            sQuery += "    JOIN personen b\n";
            sQuery += "        ON a.id_user = b.id) daten\n";
            sQuery += "ORDER BY datum_uhr DESC\n";

            return sQuery;
        }

    }
}
