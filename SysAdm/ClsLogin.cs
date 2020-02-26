using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysAdm
{
    class ClsLogin
    {
        public static ClsLogin UserLogged;
        ClsConnection connection = new ClsConnection();

        private int mID;
        private string mLogin;
        private string mPwd;
        private string mName;
        private string mDt_LastLogin;
        private string mDt_Register;
        private List<int> mPermissions;

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public string Login
        {
            get { return mLogin; }
            set { mLogin = value; }
        }
        public string Pwd
        {
            get { return mPwd; }
            set { mPwd = value; }
        }
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public List<int> Permissions
        {
            get { return mPermissions; }
            set { mPermissions = value; }
        }
        public string Dt_LastLogin
        {
            get { return mDt_LastLogin; }
            set { mDt_LastLogin = value; }
        }
        public string Dt_Register
        {
            get { return mDt_Register; }
            set { mDt_Register = value; }
        }



        public string LoginValidation()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarLogin", connection.Connect())
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@pLogin", Login);
                cmd.Parameters.AddWithValue("@pSenha", Pwd);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (dr.Read())
                {
                    UserLogged = new ClsLogin();
                    UserLogged.ID = int.Parse(dr["ID"].ToString());
                    UserLogged.Name = dr["Nome"].ToString();
                    UserLogged.Login = Login;
                    UserLogged.Dt_Register = dr["DataCadastro"].ToString();
                    UserLogged.mDt_LastLogin = dr["UltimoLogin"].ToString();
                    UserLogged.Permissions = ClsUser.GetUserPermissions(UserLogged.ID);
                    SetLoginDate();
                    return "true";
                }
                else
                    return "false";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private void SetLoginDate()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_Set_DataLogin", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", UserLogged.ID);
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
            catch
            {
            }
        }
    }
}
