SELECT tblEvent.EventName,

DATENAME(DW,EventDate) + ' ' +
DATENAME(DD,EventDate) + ' ' +
DATENAME(MM,EventDate) + ' ' +
DATENAME(YY,EventDate) AS 'Full date'

FROM tblEvent;