/*
*Name: [FangXing_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangXing_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangXing_Add]
GO
CREATE procedure [FangXing_Add]
@F_SuoShuBuMenSN int,
@F_SuoShuXiTongSN int,
@F_SuoShuBingGuanSN int,
@F_Name nvarchar(50),
@F_Detail nvarchar(200),
@F_ZhengJianJiaGe float,
@F_ChuangWei1JiaGe float,
@F_ChuangWei2JiaGe float,
@F_ChuangWei3JiaGe float,
@F_ChuangWei4JiaGe float,
@F_ChuangWei5JiaGe float,
@F_ShiFouShanChu bit,
@F_AddDate datetime
AS
Insert into FangXing
(
F_SuoShuBuMenSN,
F_SuoShuXiTongSN,
F_SuoShuBingGuanSN,
F_Name,
F_Detail,
F_ZhengJianJiaGe,
F_ChuangWei1JiaGe,
F_ChuangWei2JiaGe,
F_ChuangWei3JiaGe,
F_ChuangWei4JiaGe,
F_ChuangWei5JiaGe,
F_ShiFouShanChu,
F_AddDate
)
Values
(
@F_SuoShuBuMenSN,
@F_SuoShuXiTongSN,
@F_SuoShuBingGuanSN,
@F_Name,
@F_Detail,
@F_ZhengJianJiaGe,
@F_ChuangWei1JiaGe,
@F_ChuangWei2JiaGe,
@F_ChuangWei3JiaGe,
@F_ChuangWei4JiaGe,
@F_ChuangWei5JiaGe,
@F_ShiFouShanChu,
@F_AddDate
)




/*
*Name: [FangXing_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangXing_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangXing_Delete]
GO
CREATE procedure [FangXing_Delete]
@F_SN int
AS
Delete from FangXing where F_SN=@F_SN




/*
*Name: [FangXing_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangXing_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangXing_Get]
GO
CREATE procedure [FangXing_Get]
@F_SN int
AS
select top 1 * from FangXing where F_SN=@F_SN




/*
*Name: [FangXing_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangXing_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangXing_List]
GO
CREATE procedure [FangXing_List]
AS
select * from FangXing




/*
*Name: [FangXing_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangXing_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangXing_Set]
GO
CREATE procedure [FangXing_Set]
@F_SN int,
@F_SuoShuBuMenSN int,
@F_SuoShuXiTongSN int,
@F_SuoShuBingGuanSN int,
@F_Name nvarchar(50),
@F_Detail nvarchar(200),
@F_ZhengJianJiaGe float,
@F_ChuangWei1JiaGe float,
@F_ChuangWei2JiaGe float,
@F_ChuangWei3JiaGe float,
@F_ChuangWei4JiaGe float,
@F_ChuangWei5JiaGe float,
@F_ShiFouShanChu bit,
@F_AddDate datetime
AS
update FangXing Set
F_SuoShuBuMenSN=@F_SuoShuBuMenSN,
F_SuoShuXiTongSN=@F_SuoShuXiTongSN,
F_SuoShuBingGuanSN=@F_SuoShuBingGuanSN,
F_Name=@F_Name,
F_Detail=@F_Detail,
F_ZhengJianJiaGe=@F_ZhengJianJiaGe,
F_ChuangWei1JiaGe=@F_ChuangWei1JiaGe,
F_ChuangWei2JiaGe=@F_ChuangWei2JiaGe,
F_ChuangWei3JiaGe=@F_ChuangWei3JiaGe,
F_ChuangWei4JiaGe=@F_ChuangWei4JiaGe,
F_ChuangWei5JiaGe=@F_ChuangWei5JiaGe,
F_ShiFouShanChu=@F_ShiFouShanChu,
F_AddDate=@F_AddDate
where F_SN=@F_SN
