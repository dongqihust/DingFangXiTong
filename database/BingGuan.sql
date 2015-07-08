/*
*Name: [BingGuan_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[BingGuan_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [BingGuan_Add]
GO
CREATE procedure [BingGuan_Add]
@B_SuoShuBuMenSN int,
@B_SuoShuDingFangXiTongSN int,
@B_Name nvarchar(50),
@B_Address nvarchar(100),
@B_Phone nvarchar(20),
@B_ShiFouShanChu bit,
@B_AddDate datetime
AS
Insert into BingGuan
(
B_SuoShuBuMenSN,
B_SuoShuDingFangXiTongSN,
B_Name,
B_Address,
B_Phone,
B_ShiFouShanChu,
B_AddDate
)
Values
(
@B_SuoShuBuMenSN,
@B_SuoShuDingFangXiTongSN,
@B_Name,
@B_Address,
@B_Phone,
@B_ShiFouShanChu,
@B_AddDate
)




/*
*Name: [BingGuan_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[BingGuan_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [BingGuan_Delete]
GO
CREATE procedure [BingGuan_Delete]
@B_SN int
AS
Delete from BingGuan where B_SN=@B_SN




/*
*Name: [BingGuan_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[BingGuan_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [BingGuan_Get]
GO
CREATE procedure [BingGuan_Get]
@B_SN int
AS
select top 1 * from BingGuan where B_SN=@B_SN




/*
*Name: [BingGuan_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[BingGuan_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [BingGuan_List]
GO
CREATE procedure [BingGuan_List]
AS
select * from BingGuan




/*
*Name: [BingGuan_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[BingGuan_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [BingGuan_Set]
GO
CREATE procedure [BingGuan_Set]
@B_SN int,
@B_SuoShuBuMenSN int,
@B_SuoShuDingFangXiTongSN int,
@B_Name nvarchar(50),
@B_Address nvarchar(100),
@B_Phone nvarchar(20),
@B_ShiFouShanChu bit,
@B_AddDate datetime
AS
update BingGuan Set
B_SuoShuBuMenSN=@B_SuoShuBuMenSN,
B_SuoShuDingFangXiTongSN=@B_SuoShuDingFangXiTongSN,
B_Name=@B_Name,
B_Address=@B_Address,
B_Phone=@B_Phone,
B_ShiFouShanChu=@B_ShiFouShanChu,
B_AddDate=@B_AddDate
where B_SN=@B_SN
