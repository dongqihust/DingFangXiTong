/*
*Name: [FangJian_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJian_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJian_Add]
GO
CREATE procedure [FangJian_Add]
@F_SuoShuFangXingSN int,
@F_FangJianHao nvarchar(20),
@F_ZhengJianJiaGe float,
@F_ChuangWei1JiaGe float,
@F_ChuangWei2JiaGe float,
@F_ChuangWei3JiaGe float,
@F_ChuangWei4JiaGe float,
@F_ChuangWei5JiaGe float,
@F_Detail nvarchar(200),
@F_AddDate datetime,
@F_ShiFouShanChu bit
AS
Insert into FangJian
(
F_SuoShuFangXingSN,
F_FangJianHao,
F_ZhengJianJiaGe,
F_ChuangWei1JiaGe,
F_ChuangWei2JiaGe,
F_ChuangWei3JiaGe,
F_ChuangWei4JiaGe,
F_ChuangWei5JiaGe,
F_Detail,
F_AddDate,
F_ShiFouShanChu
)
Values
(
@F_SuoShuFangXingSN,
@F_FangJianHao,
@F_ZhengJianJiaGe,
@F_ChuangWei1JiaGe,
@F_ChuangWei2JiaGe,
@F_ChuangWei3JiaGe,
@F_ChuangWei4JiaGe,
@F_ChuangWei5JiaGe,
@F_Detail,
@F_AddDate,
@F_ShiFouShanChu
)




/*
*Name: [FangJian_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJian_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJian_Delete]
GO
CREATE procedure [FangJian_Delete]
@F_SN int
AS
Delete from FangJian where F_SN=@F_SN




/*
*Name: [FangJian_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJian_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJian_Get]
GO
CREATE procedure [FangJian_Get]
@F_SN int
AS
select top 1 * from FangJian where F_SN=@F_SN




/*
*Name: [FangJian_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJian_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJian_List]
GO
CREATE procedure [FangJian_List]
AS
select * from FangJian




/*
*Name: [FangJian_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJian_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJian_Set]
GO
CREATE procedure [FangJian_Set]
@F_SN int,
@F_SuoShuFangXingSN int,
@F_FangJianHao nvarchar(20),
@F_ZhengJianJiaGe float,
@F_ChuangWei1JiaGe float,
@F_ChuangWei2JiaGe float,
@F_ChuangWei3JiaGe float,
@F_ChuangWei4JiaGe float,
@F_ChuangWei5JiaGe float,
@F_Detail nvarchar(200),
@F_AddDate datetime,
@F_ShiFouShanChu bit
AS
update FangJian Set
F_SuoShuFangXingSN=@F_SuoShuFangXingSN,
F_FangJianHao=@F_FangJianHao,
F_ZhengJianJiaGe=@F_ZhengJianJiaGe,
F_ChuangWei1JiaGe=@F_ChuangWei1JiaGe,
F_ChuangWei2JiaGe=@F_ChuangWei2JiaGe,
F_ChuangWei3JiaGe=@F_ChuangWei3JiaGe,
F_ChuangWei4JiaGe=@F_ChuangWei4JiaGe,
F_ChuangWei5JiaGe=@F_ChuangWei5JiaGe,
F_Detail=@F_Detail,
F_AddDate=@F_AddDate,
F_ShiFouShanChu=@F_ShiFouShanChu
where F_SN=@F_SN
