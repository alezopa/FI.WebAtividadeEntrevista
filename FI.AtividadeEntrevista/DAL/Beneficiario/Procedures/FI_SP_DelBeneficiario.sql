﻿
CREATE PROC FI_SP_DelBeneficiario
	@ID BIGINT
AS
BEGIN
	DELETE BENEFICIARIOS WHERE ID = @ID
END