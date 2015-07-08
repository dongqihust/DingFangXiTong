/*
*Name: [DingDanLogs_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanLogs_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanLogs_Add]
GO
CREATE procedure [DingDanLogs_Add]
@D_DingDanSN int,
@D_DingDanShuoMing nvarchar(200),
@D_AddIP nvarchar(100),
@D_AddDate datetime
AS
Insert into DingDanLogs
(
D_DingDanSN,
D_DingDanShuoMing,
D_AddIP,
D_AddDate
)
Values
(
@D_DingDanSN,
@D_DingDanShuoMing,
@D_AddIP,
@D_AddDate
)




/*
*Name: [DingDanLogs_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanLogs_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanLogs_Delete]
GO
CREATE procedure [DingDanLogs_Delete]
@D_SN int
AS
Delete from DingDanLogs where D_SN=@D_SN




/*
*Name: [DingDanLogs_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanLogs_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanLogs_Get]
GO
CREATE procedure [DingDanLogs_Get]
@D_SN int
AS
select top 1 * from DingDanLogs where D_SN=@D_SN




/*
*Name: [DingDanLogs_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanLogs_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanLogs_List]
GO
CREATE procedure [DingDanLogs_List]
AS
select * from DingDanLogs




/*
*Name: [DingDanLogs_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanLogs_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanLogs_Set]
GO
CREATE procedure [DingDanLogs_Set]
@D_SN int,
@D_DingDanSN int,
@D_DingDanShuoMing nvarchar(200),
@D_AddIP nvarchar(100),
@D_AddDate datetime
AS
update DingDanLogs Set
D_DingDanSN=@D_DingDanSN,
D_DingDanShuoMing=@D_DingDanShuoMing,
D_AddIP=@D_AddIP,
D_AddDate=@D_AddDate
where D_SN=@D_SN
