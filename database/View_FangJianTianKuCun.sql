
/*
*Name: [View_FangJianTianKuCun_List]
*Description: ап╠М
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[View_FangJianTianKuCun_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [View_FangJianTianKuCun_List]
GO
CREATE procedure [View_FangJianTianKuCun_List]
AS
select * from View_FangJianTianKuCun
