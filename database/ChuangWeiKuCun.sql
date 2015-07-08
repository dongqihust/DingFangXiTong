/*
*Name: [ChuangWeiKuCun_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[ChuangWeiKuCun_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [ChuangWeiKuCun_Add]
GO
CREATE procedure [ChuangWeiKuCun_Add]
@C_SuoShuBuMenSN int,
@C_SuoShuXiTongSN int,
@C_BingGuanSN int,
@C_FangXingSN int,
@C_FangJianSN int,
@C_ChuangWeiHao int,
@C_RuZhuStartDate datetime,
@C_TuiFangEndDate datetime,
@C_ChuangWei1JiaGe float,
@C_ChuangWei2JiaGe float,
@C_ChuangWei3JiaGe float,
@C_ChuangWei4JiaGe float,
@C_ChuangWei5JiaGe float,
@C_BaoLiuZhuangTai int,
@C_ShiFouShanChu bit,
@C_AddDate datetime
AS
Insert into ChuangWeiKuCun
(
C_SuoShuBuMenSN,
C_SuoShuXiTongSN,
C_BingGuanSN,
C_FangXingSN,
C_FangJianSN,
C_ChuangWeiHao,
C_RuZhuStartDate,
C_TuiFangEndDate,
C_ChuangWei1JiaGe,
C_ChuangWei2JiaGe,
C_ChuangWei3JiaGe,
C_ChuangWei4JiaGe,
C_ChuangWei5JiaGe,
C_BaoLiuZhuangTai,
C_ShiFouShanChu,
C_AddDate
)
Values
(
@C_SuoShuBuMenSN,
@C_SuoShuXiTongSN,
@C_BingGuanSN,
@C_FangXingSN,
@C_FangJianSN,
@C_ChuangWeiHao,
@C_RuZhuStartDate,
@C_TuiFangEndDate,
@C_ChuangWei1JiaGe,
@C_ChuangWei2JiaGe,
@C_ChuangWei3JiaGe,
@C_ChuangWei4JiaGe,
@C_ChuangWei5JiaGe,
@C_BaoLiuZhuangTai,
@C_ShiFouShanChu,
@C_AddDate
)




/*
*Name: [ChuangWeiKuCun_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[ChuangWeiKuCun_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [ChuangWeiKuCun_Delete]
GO
CREATE procedure [ChuangWeiKuCun_Delete]
@C_SN int
AS
Delete from ChuangWeiKuCun where C_SN=@C_SN




/*
*Name: [ChuangWeiKuCun_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[ChuangWeiKuCun_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [ChuangWeiKuCun_Get]
GO
CREATE procedure [ChuangWeiKuCun_Get]
@C_SN int
AS
select top 1 * from ChuangWeiKuCun where C_SN=@C_SN




/*
*Name: [ChuangWeiKuCun_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[ChuangWeiKuCun_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [ChuangWeiKuCun_List]
GO
CREATE procedure [ChuangWeiKuCun_List]
AS
select * from ChuangWeiKuCun




/*
*Name: [ChuangWeiKuCun_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[ChuangWeiKuCun_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [ChuangWeiKuCun_Set]
GO
CREATE procedure [ChuangWeiKuCun_Set]
@C_SN int,
@C_SuoShuBuMenSN int,
@C_SuoShuXiTongSN int,
@C_BingGuanSN int,
@C_FangXingSN int,
@C_FangJianSN int,
@C_ChuangWeiHao int,
@C_RuZhuStartDate datetime,
@C_TuiFangEndDate datetime,
@C_ChuangWei1JiaGe float,
@C_ChuangWei2JiaGe float,
@C_ChuangWei3JiaGe float,
@C_ChuangWei4JiaGe float,
@C_ChuangWei5JiaGe float,
@C_BaoLiuZhuangTai int,
@C_ShiFouShanChu bit,
@C_AddDate datetime
AS
update ChuangWeiKuCun Set
C_SuoShuBuMenSN=@C_SuoShuBuMenSN,
C_SuoShuXiTongSN=@C_SuoShuXiTongSN,
C_BingGuanSN=@C_BingGuanSN,
C_FangXingSN=@C_FangXingSN,
C_FangJianSN=@C_FangJianSN,
C_ChuangWeiHao=@C_ChuangWeiHao,
C_RuZhuStartDate=@C_RuZhuStartDate,
C_TuiFangEndDate=@C_TuiFangEndDate,
C_ChuangWei1JiaGe=@C_ChuangWei1JiaGe,
C_ChuangWei2JiaGe=@C_ChuangWei2JiaGe,
C_ChuangWei3JiaGe=@C_ChuangWei3JiaGe,
C_ChuangWei4JiaGe=@C_ChuangWei4JiaGe,
C_ChuangWei5JiaGe=@C_ChuangWei5JiaGe,
C_BaoLiuZhuangTai=@C_BaoLiuZhuangTai,
C_ShiFouShanChu=@C_ShiFouShanChu,
C_AddDate=@C_AddDate
where C_SN=@C_SN
