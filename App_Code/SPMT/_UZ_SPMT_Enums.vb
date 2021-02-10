Imports Microsoft.VisualBasic

Public Enum spmtPAStates
  Cancelled = 1
  Returned = 2
  Free = 3
  IRLinked = 4
  UnderHODFeedback = 5
  UnderApproval = 6
  ForwardedToAC = 7
  ReceivedInAC = 8
  Returning = 9
  UpdatingVoucher = 10
  VoucherUpdated = 11
  Locked = 12
  VoucherPosted = 13
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
Public Enum spmtLineTypes
  NewRecord = 0
  DirectInventory = 1
  CompositInventory = 2
  LockedNewRecord = 3
  LockedDirectInventory = 4
  LockedCompositInventory = 5
End Enum
