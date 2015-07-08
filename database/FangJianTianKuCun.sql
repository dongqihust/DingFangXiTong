/*
*Name: [FangJianTianKuCun_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJianTianKuCun_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJianTianKuCun_Add]
GO
CREATE procedure [FangJianTianKuCun_Add]
@F_SuoShuBuMenSN int,
@F_SuoShuXiTongSN int,
@F_BingGuanSN int,
@F_FangXingSN int,
@F_FangJianSN int,
@F_RuZhuStartDate datetime,
@F_TuiFangEndDate datetime,
@F_ZhengJianJiaGe float,
@F_BaoLiuZhuangTai int,
@F_ShiFouShanChu bit,
@F_AddDate datetime
AS
Insert into FangJianTianKuCun
(
F_SuoShuBuMenSN,
F_SuoShuXiTongSN,
F_BingGuanSN,
F_FangXingSN,
F_FangJianSN,
F_RuZhuStartDate,
F_TuiFangEndDate,
F_ZhengJianJiaGe,
F_BaoLiuZhuangTai,
F_ShiFouShanChu,
F_AddDate
)
Values
(
@F_SuoShuBuMenSN,
@F_SuoShuXiTongSN,
@F_BingGuanSN,
@F_FangXingSN,
@F_FangJianSN,
@F_RuZhuStartDate,
@F_TuiFangEndDate,
@F_ZhengJianJiaGe,
@F_BaoLiuZhuangTai,
@F_ShiFouShanChu,
@F_AddDate
)




/*
*Name: [FangJianTianKuCun_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJianTianKuCun_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJianTianKuCun_Delete]
GO
CREATE procedure [FangJianTianKuCun_Delete]
@F_SN int
AS
Delete from FangJianTianKuCun where F_SN=@F_SN




/*
*Name: [FangJianTianKuCun_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJianTianKuCun_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJianTianKuCun_Get]
GO
CREATE procedure [FangJianTianKuCun_Get]
@F_SN int
AS
select top 1 * from FangJianTianKuCun where F_SN=@F_SN




/*
*Name: [FangJianTianKuCun_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJianTianKuCun_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJianTianKuCun_List]
GO
CREATE procedure [FangJianTianKuCun_List]
AS
select * from FangJianTianKuCun




/*
*Name: [FangJianTianKuCun_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[FangJianTianKuCun_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [FangJianTianKuCun_Set]
GO
CREATE procedure [FangJianTianKuCun_Set]
@F_SN int,
@F_SuoShuBuMenSN int,
@F_SuoShuXiTongSN int,
@F_BingGuanSN int,
@F_FangXingSN int,
@F_FangJianSN int,
@F_RuZhuStartDate datetime,
@F_TuiFangEndDate datetime,
@F_ZhengJianJiaGe float,
@F_BaoLiuZhuangTai int,
@F_ShiFouShanChu bit,
@F_AddDate datetime
AS
update FangJianTianKuCun Set
F_SuoShuBuMenSN=@F_SuoShuBuMenSN,
F_SuoShuXiTongSN=@F_SuoShuXiTongSN,
F_BingGuanSN=@F_BingGuanSN,
F_FangXingSN=@F_FangXingSN,
F_FangJianSN=@F_FangJianSN,
F_RuZhuStartDate=@F_RuZhuStartDate,
F_TuiFangEndDate=@F_TuiFangEndDate,
F_ZhengJianJiaGe=@F_ZhengJianJiaGe,
F_BaoLiuZhuangTai=@F_BaoLiuZhuangTai,
F_ShiFouShanChu=@F_ShiFouShanChu,
F_AddDate=@F_AddDate
where F_SN=@F_SN
