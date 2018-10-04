Imports Microsoft.VisualBasic

Public Enum spmtPAStates
  Cancelled = 1
  Returned = 2
  Free = 3
  IRLinked = 4
  UnderHODFeedback = 5
  UnderApprovalHR = 6
  ForwardedToAC = 7
  ReceivedInAC = 8
  Returning = 9
  UpdatingVoucher = 10
  VoucherUpdated = 11
  Locked = 12
End Enum
Public Enum spmtDHStates
  Created = 1
  Issued = 2
  Received = 3
  NotDelivered = 4
  Cancelled = 5
  ReturnedBackToConsigner = 6
  ReturnedBackToIsgec = 7
  SentToCustomerSite = 8
  SentToAnotherVendor = 9
  UnderReceiptEntry = 10
  UnderClosureEntry = 11
End Enum
