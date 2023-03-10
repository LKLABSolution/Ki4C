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
    
    
    // Table('InputType') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class InputType : SoftBand.EntityManager.Entity
    {
        
        public InputType()
        {
            this.DefineColumns(3);
        }
        
        public int InputTypeNumber
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
        
        public string InputTypeCode
        {
            get
            {
                return ((string)(this[1]));
            }
            set
            {
                this[1] = value;
            }
        }
        
        public string InputTypeName
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
        
        public static InputTypeService Service
        {
            get
            {
                return ((InputTypeService)(GetServiceObject(typeof(InputType), typeof(InputTypeService))));
            }
        }
        
        public static InputTypeSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<InputTypeSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static InputType GetByKey(int inputTypeNumber)
        {
            return Service.GetByKey(inputTypeNumber);
        }
        
        public static string GetByKeyJson(int inputTypeNumber)
        {
            return Service.GetByKeyJson(inputTypeNumber);
        }
        
        public static async Task<InputType> GetByKeyAsync(int inputTypeNumber)
        {
            return await Service.GetByKeyAsync(inputTypeNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int inputTypeNumber)
        {
            return await Service.GetByKeyJsonAsync(inputTypeNumber);
        }
        
        public static InputType Insert(string inputTypeCode, string inputTypeName)
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Service.Insert(inputTypeCode, inputTypeName);
        }
        
        public static async Task<InputType> InsertAsync(string inputTypeCode, string inputTypeName)
        {
            // InsertAsync 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await Service.InsertAsync(inputTypeCode, inputTypeName);
        }
        
        public new InputType Insert()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Insert(InputTypeCode, InputTypeName);
        }
        
        public async Task<InputType> InsertAsync()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await InsertAsync(InputTypeCode, InputTypeName);
        }
        
        public new int Update()
        {
            // 인수를 해당 파라메타에 옮긴다
            int inputTypeNumberParam = this.InputTypeNumber;
            string inputTypeCodeParam = this.InputTypeCode;
            string inputTypeNameParam = this.InputTypeName;
            // update 실행
            return Service.Update(inputTypeNumberParam, inputTypeCodeParam, inputTypeNameParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // 인수를 해당 파라메타에 옮긴다
            int inputTypeNumberParam = this.InputTypeNumber;
            string inputTypeCodeParam = this.InputTypeCode;
            string inputTypeNameParam = this.InputTypeName;
            return await Service.UpdateAsync(inputTypeNumberParam, inputTypeCodeParam, inputTypeNameParam);
        }
        
        public static int Update(int inputTypeNumber, string inputTypeCode, string inputTypeName)
        {
            return Service.Update(inputTypeNumber, inputTypeCode, inputTypeName);
        }
        
        public static async Task<int> UpdateAsync(int inputTypeNumber, string inputTypeCode, string inputTypeName)
        {
            return await Service.UpdateAsync(inputTypeNumber, inputTypeCode, inputTypeName);
        }
        
        public static int Delete(int inputTypeNumber)
        {
            return Service.Delete(inputTypeNumber);
        }
        
        public static async Task<int> DeleteAsync(int inputTypeNumber)
        {
            return await Service.DeleteAsync(inputTypeNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(InputTypeNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(InputTypeNumber);
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
    
    
    // Table('InputType')  Service class
    // Do not add or change code here.
    public partial class InputTypeService : SoftBand.EntityManager.Service
    {
        
        public InputTypeSet GetAll()
        {
            return ((InputTypeSet)(this.GetAll("InputType", typeof(InputTypeSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("InputType");
        }
        
        public async Task<InputTypeSet> GetAllAsync()
        {
            return ((InputTypeSet)(await this.GetAllAsync("InputType", typeof(InputTypeSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("InputType");
        }
        
        public InputType GetByKey(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(selectCmd, paraNames, inputTypeNumber);
            // 
            InputType entity = ((InputType)(this.GetEntity(selectCmd, typeof(InputTypeSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(selectCmd, paraNames, inputTypeNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<InputType> GetByKeyAsync(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(selectCmd, paraNames, inputTypeNumber);
            // 
            // GetByKeyAsync 를 호출한다
            InputType entity = ((InputType)(await this.GetEntityAsync(selectCmd, typeof(InputTypeSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(selectCmd, paraNames, inputTypeNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public InputType Insert(string inputTypeCode, string inputTypeName)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO InputType(InputTypeCode, InputTypeName) OUTPUT INSERTED.InputTypeNumb" +
                "er\r\nVALUES (@inputTypeCode, @inputTypeName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeCode,inputTypeName";
            AddParameters(insertCommand, paraNames, inputTypeCode, inputTypeName);
            // 
            // Insert 를 호출한다
            InputType entity = ((InputType)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<InputType> InsertAsync(string inputTypeCode, string inputTypeName)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO InputType(InputTypeCode, InputTypeName) OUTPUT INSERTED.InputTypeNumb" +
                "er\r\nVALUES (@inputTypeCode, @inputTypeName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeCode,inputTypeName";
            AddParameters(insertCommand, paraNames, inputTypeCode, inputTypeName);
            // 
            // InsertAsync 를 호출한다
            InputType entity = ((InputType)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int inputTypeNumber, string inputTypeCode, string inputTypeName)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE InputType SET InputTypeCode = @inputTypeCode, InputTypeName = @inputTypeNa" +
                "me WHERE InputTypeNumber = @inputTypeNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber,inputTypeCode,inputTypeName";
            AddParameters(updateCmd, paraNames, inputTypeNumber, inputTypeCode, inputTypeName);
            // 
            // Update 를 호출한다
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int inputTypeNumber, string inputTypeCode, string inputTypeName)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE InputType SET InputTypeCode = @inputTypeCode, InputTypeName = @inputTypeNa" +
                "me WHERE InputTypeNumber = @inputTypeNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber,inputTypeCode,inputTypeName";
            AddParameters(updateCmd, paraNames, inputTypeNumber, inputTypeCode, inputTypeName);
            // 
            // Update 를 호출한다
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(deleteCmd, paraNames, inputTypeNumber);
            // 
            // Delete 를 호출한다
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int inputTypeNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM InputType WHERE InputTypeNumber = @inputTypeNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "inputTypeNumber";
            AddParameters(deleteCmd, paraNames, inputTypeNumber);
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
    
    
    // Table('InputType') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class InputTypeSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public InputTypeSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected InputTypeSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected InputTypeSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public InputTypeBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(InputType);
        }
        
        private InputTypeBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private InputTypeBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((InputTypeBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(InputTypeBoundCollection))));
        }
        
        public partial class InputTypeBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new InputType this[int index]
            {
                get
                {
                    return ((InputType)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
