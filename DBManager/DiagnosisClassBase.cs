//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisClass') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisClass : SoftBand.EntityManager.Entity
    {
        
        public DiagnosisClass()
        {
            this.DefineColumns(4);
        }
        
        public int DiagnosisClassNumber
        {
            get
            {
                return ((int)(this[0]));
            }
            set
            {
                this[0] = value;
            }
        }
        
        public int DiagnosisTypeNumber
        {
            get
            {
                return ((int)(this[1]));
            }
            set
            {
                this[1] = value;
            }
        }
        
        public string DiagnosisClassCode
        {
            get
            {
                return ((string)(this[2]));
            }
            set
            {
                this[2] = value;
            }
        }
        
        public string DiagnosisClassName
        {
            get
            {
                return ((string)(this[3]));
            }
            set
            {
                this[3] = value;
            }
        }
        
        public static DiagnosisClassService Service
        {
            get
            {
                return ((DiagnosisClassService)(GetServiceObject(typeof(DiagnosisClass), typeof(DiagnosisClassService))));
            }
        }
        
        public static DiagnosisClassSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<DiagnosisClassSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static DiagnosisClassSet GetForDiagnosisType(int diagnosisTypeNumber)
        {
            return Service.GetForDiagnosisType(diagnosisTypeNumber);
        }
        
        public static async Task<DiagnosisClassSet> GetForDiagnosisTypeAsync(int diagnosisTypeNumber)
        {
            return await Service.GetForDiagnosisTypeAsync(diagnosisTypeNumber);
        }
        
        public static string GetForDiagnosisTypeJson(int diagnosisTypeNumber)
        {
            return Service.GetForDiagnosisTypeJson(diagnosisTypeNumber);
        }
        
        public static async Task<string> GetForDiagnosisTypeJsonAsync(int diagnosisTypeNumber)
        {
            return await Service.GetForDiagnosisTypeJsonAsync(diagnosisTypeNumber);
        }
        
        public static DiagnosisClass GetByKey(int diagnosisClassNumber)
        {
            return Service.GetByKey(diagnosisClassNumber);
        }
        
        public static string GetByKeyJson(int diagnosisClassNumber)
        {
            return Service.GetByKeyJson(diagnosisClassNumber);
        }
        
        public static async Task<DiagnosisClass> GetByKeyAsync(int diagnosisClassNumber)
        {
            return await Service.GetByKeyAsync(diagnosisClassNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int diagnosisClassNumber)
        {
            return await Service.GetByKeyJsonAsync(diagnosisClassNumber);
        }
        
        public static DiagnosisClass Insert(int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Service.Insert(diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
        }
        
        public static async Task<DiagnosisClass> InsertAsync(int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // InsertAsync ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await Service.InsertAsync(diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
        }
        
        public new DiagnosisClass Insert()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Insert(DiagnosisTypeNumber, DiagnosisClassCode, DiagnosisClassName);
        }
        
        public async Task<DiagnosisClass> InsertAsync()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await InsertAsync(DiagnosisTypeNumber, DiagnosisClassCode, DiagnosisClassName);
        }
        
        public new int Update()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisClassNumberParam = this.DiagnosisClassNumber;
            int diagnosisTypeNumberParam = this.DiagnosisTypeNumber;
            string diagnosisClassCodeParam = this.DiagnosisClassCode;
            string diagnosisClassNameParam = this.DiagnosisClassName;
            // update ??????
            return Service.Update(diagnosisClassNumberParam, diagnosisTypeNumberParam, diagnosisClassCodeParam, diagnosisClassNameParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisClassNumberParam = this.DiagnosisClassNumber;
            int diagnosisTypeNumberParam = this.DiagnosisTypeNumber;
            string diagnosisClassCodeParam = this.DiagnosisClassCode;
            string diagnosisClassNameParam = this.DiagnosisClassName;
            return await Service.UpdateAsync(diagnosisClassNumberParam, diagnosisTypeNumberParam, diagnosisClassCodeParam, diagnosisClassNameParam);
        }
        
        public static int Update(int diagnosisClassNumber, int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            return Service.Update(diagnosisClassNumber, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
        }
        
        public static async Task<int> UpdateAsync(int diagnosisClassNumber, int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            return await Service.UpdateAsync(diagnosisClassNumber, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
        }
        
        public static int Delete(int diagnosisClassNumber)
        {
            return Service.Delete(diagnosisClassNumber);
        }
        
        public static async Task<int> DeleteAsync(int diagnosisClassNumber)
        {
            return await Service.DeleteAsync(diagnosisClassNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(DiagnosisClassNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(DiagnosisClassNumber);
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisClass')  Service class
    // Do not add or change code here.
    public partial class DiagnosisClassService : SoftBand.EntityManager.Service
    {
        
        public DiagnosisClassSet GetAll()
        {
            return ((DiagnosisClassSet)(this.GetAll("DiagnosisClass", typeof(DiagnosisClassSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("DiagnosisClass");
        }
        
        public async Task<DiagnosisClassSet> GetAllAsync()
        {
            return ((DiagnosisClassSet)(await this.GetAllAsync("DiagnosisClass", typeof(DiagnosisClassSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("DiagnosisClass");
        }
        
        public DiagnosisClassSet GetForDiagnosisType(int diagnosisTypeNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [DiagnosisClass] WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            DiagnosisClassSet entitySet = ((DiagnosisClassSet)(this.GetEntitySet(selectCmd, typeof(DiagnosisClassSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public async Task<DiagnosisClassSet> GetForDiagnosisTypeAsync(int diagnosisTypeNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [DiagnosisClass] WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            DiagnosisClassSet entitySet = ((DiagnosisClassSet)(await this.GetEntitySetAsync(selectCmd, typeof(DiagnosisClassSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public string GetForDiagnosisTypeJson(int diagnosisTypeNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [DiagnosisClass] WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            return  this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<string> GetForDiagnosisTypeJsonAsync(int diagnosisTypeNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [DiagnosisClass] WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public DiagnosisClass GetByKey(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(selectCmd, paraNames, diagnosisClassNumber);
            // 
            DiagnosisClass entity = ((DiagnosisClass)(this.GetEntity(selectCmd, typeof(DiagnosisClassSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(selectCmd, paraNames, diagnosisClassNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<DiagnosisClass> GetByKeyAsync(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(selectCmd, paraNames, diagnosisClassNumber);
            // 
            // GetByKeyAsync ??? ????????????
            DiagnosisClass entity = ((DiagnosisClass)(await this.GetEntityAsync(selectCmd, typeof(DiagnosisClassSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(selectCmd, paraNames, diagnosisClassNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public DiagnosisClass Insert(int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisClass(DiagnosisTypeNumber, DiagnosisClassCode, DiagnosisClas" +
                "sName) OUTPUT INSERTED.DiagnosisClassNumber\r\nVALUES (@diagnosisTypeNumber, @diag" +
                "nosisClassCode, @diagnosisClassName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber,diagnosisClassCode,diagnosisClassName";
            AddParameters(insertCommand, paraNames, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
            // 
            // Insert ??? ????????????
            DiagnosisClass entity = ((DiagnosisClass)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<DiagnosisClass> InsertAsync(int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisClass(DiagnosisTypeNumber, DiagnosisClassCode, DiagnosisClas" +
                "sName) OUTPUT INSERTED.DiagnosisClassNumber\r\nVALUES (@diagnosisTypeNumber, @diag" +
                "nosisClassCode, @diagnosisClassName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber,diagnosisClassCode,diagnosisClassName";
            AddParameters(insertCommand, paraNames, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
            // 
            // InsertAsync ??? ????????????
            DiagnosisClass entity = ((DiagnosisClass)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int diagnosisClassNumber, int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisClass SET DiagnosisTypeNumber = @diagnosisTypeNumber, DiagnosisCl" +
                "assCode = @diagnosisClassCode, DiagnosisClassName = @diagnosisClassName WHERE Di" +
                "agnosisClassNumber = @diagnosisClassNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber,diagnosisTypeNumber,diagnosisClassCode,diagnosisClassName";
            AddParameters(updateCmd, paraNames, diagnosisClassNumber, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
            // 
            // Update ??? ????????????
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int diagnosisClassNumber, int diagnosisTypeNumber, string diagnosisClassCode, string diagnosisClassName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisClass SET DiagnosisTypeNumber = @diagnosisTypeNumber, DiagnosisCl" +
                "assCode = @diagnosisClassCode, DiagnosisClassName = @diagnosisClassName WHERE Di" +
                "agnosisClassNumber = @diagnosisClassNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber,diagnosisTypeNumber,diagnosisClassCode,diagnosisClassName";
            AddParameters(updateCmd, paraNames, diagnosisClassNumber, diagnosisTypeNumber, diagnosisClassCode, diagnosisClassName);
            // 
            // Update ??? ????????????
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(deleteCmd, paraNames, diagnosisClassNumber);
            // 
            // Delete ??? ????????????
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int diagnosisClassNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisClass WHERE DiagnosisClassNumber = @diagnosisClassNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisClassNumber";
            AddParameters(deleteCmd, paraNames, diagnosisClassNumber);
            // 
            // Delete ??? ????????????
            int executeCnt = await this.ExecuteNonQueryAsync(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisClass') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisClassSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public DiagnosisClassSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected DiagnosisClassSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected DiagnosisClassSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public DiagnosisClassBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(DiagnosisClass);
        }
        
        private DiagnosisClassBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private DiagnosisClassBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((DiagnosisClassBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(DiagnosisClassBoundCollection))));
        }
        
        public partial class DiagnosisClassBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new DiagnosisClass this[int index]
            {
                get
                {
                    return ((DiagnosisClass)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
