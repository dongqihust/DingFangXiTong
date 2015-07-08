/*
*Name: [DingFangXiTong_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingFangXiTong_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingFangXiTong_Add]
GO
CREATE procedure [DingFangXiTong_Add]
@D_SuoShuBuMenSN int,
@D_Name nvarchar(50),
@D_BanJiSNs nvarchar(200),
@D_AddDate datetime,
@D_ShiFouShanChu bit
AS
Insert into DingFangXiTong
(
D_SuoShuBuMenSN,
D_Name,
D_BanJiSNs,
D_AddDate,
D_ShiFouShanChu
)
Values
(
@D_SuoShuBuMenSN,
@D_Name,
@D_BanJiSNs,
@D_AddDate,
@D_ShiFouShanChu
)




/*
*Name: [DingFangXiTong_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingFangXiTong_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingFangXiTong_Delete]
GO
CREATE procedure [DingFangXiTong_Delete]
@D_SN int
AS
Delete from DingFangXiTong where D_SN=@D_SN




/*
*Name: [DingFangXiTong_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingFangXiTong_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingFangXiTong_Get]
GO
CREATE procedure [DingFangXiTong_Get]
@D_SN int
AS
select top 1 * from DingFangXiTong where D_SN=@D_SN




/*
*Name: [DingFangXiTong_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingFangXiTong_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingFangXiTong_List]
GO
CREATE procedure [DingFangXiTong_List]
AS
select * from DingFangXiTong




/*
*Name: [DingFangXiTong_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingFangXiTong_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingFangXiTong_Set]
GO
CREATE procedure [DingFangXiTong_Set]
@D_SN int,
@D_SuoShuBuMenSN int,
@D_Name nvarchar(50),
@D_BanJiSNs nvarchar(200),
@D_AddDate datetime,
@D_ShiFouShanChu bit
AS
update DingFangXiTong Set
D_SuoShuBuMenSN=@D_SuoShuBuMenSN,
D_Name=@D_Name,
D_BanJiSNs=@D_BanJiSNs,
D_AddDate=@D_AddDate,
D_ShiFouShanChu=@D_ShiFouShanChu
where D_SN=@D_SN
