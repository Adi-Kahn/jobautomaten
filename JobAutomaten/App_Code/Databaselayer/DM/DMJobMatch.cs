using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using JobAutomaten.html;

public class DMJobMatch
    {
        public DMJobMatch()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public int updateJobMatch(DDJobMatch m_ddJobMatch)
        {
            TBLJobMatch pDAL = new TBLJobMatch();
            try
            {
                return pDAL.updateJobMatch(m_ddJobMatch);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }
        public int insertJobMatch(DDJobMatch m_ddJobMatch)
        {
            TBLJobMatch pDAL = new TBLJobMatch();
            try
            {
                return pDAL.insertJobMatch(m_ddJobMatch);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }
        public DataTable GetAllJobMatch()
        {
            TBLJobMatch pDAL = new TBLJobMatch();
            try
            {
                return pDAL.GetAllJobMatch();
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }
        public DataTable GetAllJobMatchbyid(string id)
        {
            TBLJobMatch pDAL = new TBLJobMatch();
            try
            {
                return pDAL.GetAllJobMatchbyId(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }
    }

