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
    
    
    // Table('AttachmentFiles') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class AttachmentFil : SoftBand.EntityManager.Entity
    {
        
        public AttachmentFil()
        {
            this.DefineColumns(4);
        }
        
        public int AttachmentFileNumber
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
        
        public int EvaluationAnswerNumber
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
        
        public string AttachmentFileName
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
        
        public int AttachmentFileSize
        {
            get
            {
                return ((int)(this[3]));
            }
            set
            {
                this[3] = value;
            }
        }
        
        public static AttachmentFilService Service
        {
            get
            {
                return ((AttachmentFilService)(GetServiceObject(typeof(AttachmentFil), typeof(AttachmentFilService))));
            }
        }
        
        public static AttachmentFilSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<AttachmentFilSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static AttachmentFilSet GetForDiagnosisEvaluationAnswer(int evaluationAnswerNumber)
        {
            return Service.GetForDiagnosisEvaluationAnswer(evaluationAnswerNumber);
        }
        
        public static async Task<AttachmentFilSet> GetForDiagnosisEvaluationAnswerAsync(int evaluationAnswerNumber)
        {
            return await Service.GetForDiagnosisEvaluationAnswerAsync(evaluationAnswerNumber);
        }
        
        public static string GetForDiagnosisEvaluationAnswerJson(int evaluationAnswerNumber)
        {
            return Service.GetForDiagnosisEvaluationAnswerJson(evaluationAnswerNumber);
        }
        
        public static async Task<string> GetForDiagnosisEvaluationAnswerJsonAsync(int evaluationAnswerNumber)
        {
            return await Service.GetForDiagnosisEvaluationAnswerJsonAsync(evaluationAnswerNumber);
        }
        
        public static AttachmentFil GetByKey(int attachmentFileNumber)
        {
            return Service.GetByKey(attachmentFileNumber);
        }
        
        public static string GetByKeyJson(int attachmentFileNumber)
        {
            return Service.GetByKeyJson(attachmentFileNumber);
        }
        
        public static async Task<AttachmentFil> GetByKeyAsync(int attachmentFileNumber)
        {
            return await Service.GetByKeyAsync(attachmentFileNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int attachmentFileNumber)
        {
            return await Service.GetByKeyJsonAsync(attachmentFileNumber);
        }
        
        public static AttachmentFil Insert(int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Service.Insert(evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
        }
        
        public static async Task<AttachmentFil> InsertAsync(int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // InsertAsync 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await Service.InsertAsync(evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
        }
        
        public new AttachmentFil Insert()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Insert(EvaluationAnswerNumber, AttachmentFileName, AttachmentFileSize);
        }
        
        public async Task<AttachmentFil> InsertAsync()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await InsertAsync(EvaluationAnswerNumber, AttachmentFileName, AttachmentFileSize);
        }
        
        public new int Update()
        {
            // 인수를 해당 파라메타에 옮긴다
            int attachmentFileNumberParam = this.AttachmentFileNumber;
            int evaluationAnswerNumberParam = this.EvaluationAnswerNumber;
            string attachmentFileNameParam = this.AttachmentFileName;
            int attachmentFileSizeParam = this.AttachmentFileSize;
            // update 실행
            return Service.Update(attachmentFileNumberParam, evaluationAnswerNumberParam, attachmentFileNameParam, attachmentFileSizeParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // 인수를 해당 파라메타에 옮긴다
            int attachmentFileNumberParam = this.AttachmentFileNumber;
            int evaluationAnswerNumberParam = this.EvaluationAnswerNumber;
            string attachmentFileNameParam = this.AttachmentFileName;
            int attachmentFileSizeParam = this.AttachmentFileSize;
            return await Service.UpdateAsync(attachmentFileNumberParam, evaluationAnswerNumberParam, attachmentFileNameParam, attachmentFileSizeParam);
        }
        
        public static int Update(int attachmentFileNumber, int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            return Service.Update(attachmentFileNumber, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
        }
        
        public static async Task<int> UpdateAsync(int attachmentFileNumber, int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            return await Service.UpdateAsync(attachmentFileNumber, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
        }
        
        public static int Delete(int attachmentFileNumber)
        {
            return Service.Delete(attachmentFileNumber);
        }
        
        public static async Task<int> DeleteAsync(int attachmentFileNumber)
        {
            return await Service.DeleteAsync(attachmentFileNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(AttachmentFileNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(AttachmentFileNumber);
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
    
    
    // Table('AttachmentFiles')  Service class
    // Do not add or change code here.
    public partial class AttachmentFilService : SoftBand.EntityManager.Service
    {
        
        public AttachmentFilSet GetAll()
        {
            return ((AttachmentFilSet)(this.GetAll("AttachmentFiles", typeof(AttachmentFilSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("AttachmentFiles");
        }
        
        public async Task<AttachmentFilSet> GetAllAsync()
        {
            return ((AttachmentFilSet)(await this.GetAllAsync("AttachmentFiles", typeof(AttachmentFilSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("AttachmentFiles");
        }
        
        public AttachmentFilSet GetForDiagnosisEvaluationAnswer(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [AttachmentFiles] WHERE EvaluationAnswerNumber = @evaluationAnswerN" +
                "umber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            AttachmentFilSet entitySet = ((AttachmentFilSet)(this.GetEntitySet(selectCmd, typeof(AttachmentFilSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public async Task<AttachmentFilSet> GetForDiagnosisEvaluationAnswerAsync(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [AttachmentFiles] WHERE EvaluationAnswerNumber = @evaluationAnswerN" +
                "umber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            AttachmentFilSet entitySet = ((AttachmentFilSet)(await this.GetEntitySetAsync(selectCmd, typeof(AttachmentFilSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public string GetForDiagnosisEvaluationAnswerJson(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [AttachmentFiles] WHERE EvaluationAnswerNumber = @evaluationAnswerN" +
                "umber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            return  this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<string> GetForDiagnosisEvaluationAnswerJsonAsync(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [AttachmentFiles] WHERE EvaluationAnswerNumber = @evaluationAnswerN" +
                "umber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public AttachmentFil GetByKey(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(selectCmd, paraNames, attachmentFileNumber);
            // 
            AttachmentFil entity = ((AttachmentFil)(this.GetEntity(selectCmd, typeof(AttachmentFilSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(selectCmd, paraNames, attachmentFileNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<AttachmentFil> GetByKeyAsync(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(selectCmd, paraNames, attachmentFileNumber);
            // 
            // GetByKeyAsync 를 호출한다
            AttachmentFil entity = ((AttachmentFil)(await this.GetEntityAsync(selectCmd, typeof(AttachmentFilSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(selectCmd, paraNames, attachmentFileNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public AttachmentFil Insert(int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO AttachmentFiles(EvaluationAnswerNumber, AttachmentFileName, Attachmen" +
                "tFileSize) OUTPUT INSERTED.AttachmentFileNumber\r\nVALUES (@evaluationAnswerNumber" +
                ", @attachmentFileName, @attachmentFileSize) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationAnswerNumber,attachmentFileName,attachmentFileSize";
            AddParameters(insertCommand, paraNames, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
            // 
            // Insert 를 호출한다
            AttachmentFil entity = ((AttachmentFil)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<AttachmentFil> InsertAsync(int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO AttachmentFiles(EvaluationAnswerNumber, AttachmentFileName, Attachmen" +
                "tFileSize) OUTPUT INSERTED.AttachmentFileNumber\r\nVALUES (@evaluationAnswerNumber" +
                ", @attachmentFileName, @attachmentFileSize) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationAnswerNumber,attachmentFileName,attachmentFileSize";
            AddParameters(insertCommand, paraNames, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
            // 
            // InsertAsync 를 호출한다
            AttachmentFil entity = ((AttachmentFil)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int attachmentFileNumber, int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE AttachmentFiles SET EvaluationAnswerNumber = @evaluationAnswerNumber, Atta" +
                "chmentFileName = @attachmentFileName, AttachmentFileSize = @attachmentFileSize W" +
                "HERE AttachmentFileNumber = @attachmentFileNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber,evaluationAnswerNumber,attachmentFileName,attachmentFileSize" +
                "";
            AddParameters(updateCmd, paraNames, attachmentFileNumber, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
            // 
            // Update 를 호출한다
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int attachmentFileNumber, int evaluationAnswerNumber, string attachmentFileName, int attachmentFileSize)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE AttachmentFiles SET EvaluationAnswerNumber = @evaluationAnswerNumber, Atta" +
                "chmentFileName = @attachmentFileName, AttachmentFileSize = @attachmentFileSize W" +
                "HERE AttachmentFileNumber = @attachmentFileNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber,evaluationAnswerNumber,attachmentFileName,attachmentFileSize" +
                "";
            AddParameters(updateCmd, paraNames, attachmentFileNumber, evaluationAnswerNumber, attachmentFileName, attachmentFileSize);
            // 
            // Update 를 호출한다
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(deleteCmd, paraNames, attachmentFileNumber);
            // 
            // Delete 를 호출한다
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int attachmentFileNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM AttachmentFiles WHERE AttachmentFileNumber = @attachmentFileNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "attachmentFileNumber";
            AddParameters(deleteCmd, paraNames, attachmentFileNumber);
            // 
            // Delete 를 호출한다
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
    
    
    // Table('AttachmentFiles') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class AttachmentFilSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public AttachmentFilSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected AttachmentFilSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected AttachmentFilSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public AttachmentFilBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(AttachmentFil);
        }
        
        private AttachmentFilBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private AttachmentFilBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((AttachmentFilBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(AttachmentFilBoundCollection))));
        }
        
        public partial class AttachmentFilBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new AttachmentFil this[int index]
            {
                get
                {
                    return ((AttachmentFil)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
