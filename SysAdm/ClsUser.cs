using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysAdm
{

    class ClsUser : ClsCrud
    {
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


        public override string Update()       
        {
            connection = new ClsConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Upd_Usuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Name);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Login);
                cmd.Parameters.AddWithValue("@pDs_Senha", Pwd);
                cmd.Parameters.AddWithValue("@pId_Usuario", ID);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return InsertUserPermissions(ID, Permissions);
                }
                else
                {
                    return "Falha no banco de dados ao tentar atualizar usuario \n A função ExecuteNomQuery retornou 0 linhas afetas quando o valor deveria ser um mais.";
                }
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            finally
            {
                connection.Disconnect();
            }
        }
        public override string Query()       
        {
            connection = new ClsConnection();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_Sel_Usuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", ID);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                dr.Read();

                Name = dr["Nome"].ToString();
                Login = dr["Login"].ToString();
                Pwd = dr["Senha"].ToString();
                Dt_Register = dr["DataCadastro"].ToString();
                Dt_LastLogin = dr["UltimoLogin"].ToString();
                Permissions = GetUserPermissions(ID);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                connection.Disconnect();
            }
        }
        public override string Delete()
        {
            connection = new ClsConnection();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_Del_Usuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", ID);

                if (cmd.ExecuteNonQuery() > 0)
                    return "OK";
                else
                    return "Função ExecuteNonQuery Retornou 0 linhas alteradas, sendo que devia ter sido alterado pelo menos 1.";
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            finally
            {
                connection.Disconnect();
            }
        }
        public override string Grid()
        {
            string resultado = string.Empty;

            connection = new ClsConnection();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_Grid_Usuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Name);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Login);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                da.Fill(Ds);
                return "OK";
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            finally
            {
                connection.Disconnect();
            }
        }
        public override string Insert()
        {
            connection = new ClsConnection();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_Ins_Usuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Name);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Login);
                cmd.Parameters.AddWithValue("@pDs_Senha", Pwd);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return InsertUserPermissions(int.Parse(dr["ID"].ToString()), Permissions);
                else
                    return "Falha no banco de dados ao tenatr inserir funcionario/nA função ExecuteNomQuery Retornou 0 linhas afetadas quando o valor deveria ser igual ou mair que 1";
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            finally
            {
                connection.Disconnect();
            }
        }

        public static List<int> GetUserPermissions(int id)
        {
            ClsConnection connection = new ClsConnection();
            List<int> permissions = new List<int>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_PermissoesUsuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Usuario", id);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    permissions.Add(int.Parse(dr["ID"].ToString()));
                }
                connection.Disconnect();
                return (permissions);
            }
            catch
            {
                connection.Disconnect();
                return (null);
            }
        }
        public static bool CheckLogin(string login)
        {
            ClsConnection connection = new ClsConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarProntuario", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pDs_Prontuario", login);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private string InsertUserPermissions(int id, List<int> permissoes)
        {
            connection = new ClsConnection();
            SqlTransaction transaction;
            connection.Connect();

            transaction = connection.Connect().BeginTransaction("transactionPermissions");

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Del_PermissoesUsuario", transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@pID_Usuario", id);

                cmd.ExecuteNonQuery();

                for (int i = 0; i < Permissions.Count; i++)
                {
                    cmd = new SqlCommand("sp_Ins_PermissoesUsuario", transaction.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@pID_Usuario", id);
                    cmd.Parameters.AddWithValue("@pID_Funcionalidade", Permissions[i]);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                connection.Disconnect();
                return ("OK");
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                    return ex.ToString();
                }
                catch (Exception ex2)
                {
                    return ex.ToString() + ex2.ToString();
                }
            }
        }
        public string GetFuncionalidades()
        {
            connection = new ClsConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_Funcionalidades", connection.Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                da.Fill(Ds);
                connection.Disconnect();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                connection.Disconnect();
            }
        }
    }
}

