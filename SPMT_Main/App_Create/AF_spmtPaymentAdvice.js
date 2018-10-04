<script type="text/javascript"> 
var script_spmtPaymentAdvice = {
    ACEBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('BPID','');
      var F_BPID = $get(sender._element.id);
      var F_BPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_BPID.value = p[0];
      F_BPID_Display.innerHTML = e.get_text();
    },
    ACEBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('BPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConcernedHOD_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConcernedHOD','');
      var F_ConcernedHOD = $get(sender._element.id);
      var F_ConcernedHOD_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConcernedHOD.value = p[0];
      F_ConcernedHOD_Display.innerHTML = e.get_text();
    },
    ACEConcernedHOD_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConcernedHOD','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConcernedHOD_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEProjectID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ProjectID','');
      var F_ProjectID = $get(sender._element.id);
      var F_ProjectID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ProjectID.value = p[0];
      F_ProjectID_Display.innerHTML = e.get_text();
    },
    ACEProjectID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ProjectID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEProjectID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEElementID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ElementID','');
      var F_ElementID = $get(sender._element.id);
      var F_ElementID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ElementID.value = p[0];
      F_ElementID_Display.innerHTML = e.get_text();
    },
    ACEElementID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ElementID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEElementID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEEmployeeID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('EmployeeID','');
      var F_EmployeeID = $get(sender._element.id);
      var F_EmployeeID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_EmployeeID.value = p[0];
      F_EmployeeID_Display.innerHTML = e.get_text();
    },
    ACEEmployeeID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('EmployeeID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEEmployeeID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_BPID: function(sender) {
      var Prefix = sender.id.replace('BPID','');
      this.validated_FK_SPMT_PaymentAdvice_BPID_main = true;
      this.validate_FK_SPMT_PaymentAdvice_BPID(sender,Prefix);
      },
    validate_ConcernedHOD: function(sender) {
      var Prefix = sender.id.replace('ConcernedHOD','');
      this.validated_FK_SPMT_PaymentAdvice_ConcernedHOD_main = true;
      this.validate_FK_SPMT_PaymentAdvice_ConcernedHOD(sender,Prefix);
      },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_PaymentAdvice_ProjectsID_main = true;
      this.validate_FK_SPMT_PaymentAdvice_ProjectsID(sender,Prefix);
      },
    validate_ElementID: function(sender) {
      var Prefix = sender.id.replace('ElementID','');
      this.validated_FK_SPMT_PaymentAdvice_WBS_main = true;
      this.validate_FK_SPMT_PaymentAdvice_WBS(sender,Prefix);
      },
    validate_EmployeeID: function(sender) {
      var Prefix = sender.id.replace('EmployeeID','');
      this.validated_FK_SPMT_PaymentAdvice_EmployeeID_main = true;
      this.validate_FK_SPMT_PaymentAdvice_EmployeeID(sender,Prefix);
      },
    validate_FK_SPMT_PaymentAdvice_ConcernedHOD: function(o,Prefix) {
      var value = o.id;
      var ConcernedHOD = $get(Prefix + 'ConcernedHOD');
      if(ConcernedHOD.value==''){
        if(this.validated_FK_SPMT_PaymentAdvice_ConcernedHOD_main){
          var o_d = $get(Prefix + 'ConcernedHOD' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConcernedHOD.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_PaymentAdvice_ConcernedHOD(value, this.validated_FK_SPMT_PaymentAdvice_ConcernedHOD);
      },
    validated_FK_SPMT_PaymentAdvice_ConcernedHOD_main: false,
    validated_FK_SPMT_PaymentAdvice_ConcernedHOD: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtPaymentAdvice.validated_FK_SPMT_PaymentAdvice_ConcernedHOD_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_PaymentAdvice_EmployeeID: function(o,Prefix) {
      var value = o.id;
      var EmployeeID = $get(Prefix + 'EmployeeID');
      if(EmployeeID.value==''){
        if(this.validated_FK_SPMT_PaymentAdvice_EmployeeID_main){
          var o_d = $get(Prefix + 'EmployeeID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + EmployeeID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_PaymentAdvice_EmployeeID(value, this.validated_FK_SPMT_PaymentAdvice_EmployeeID);
      },
    validated_FK_SPMT_PaymentAdvice_EmployeeID_main: false,
    validated_FK_SPMT_PaymentAdvice_EmployeeID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtPaymentAdvice.validated_FK_SPMT_PaymentAdvice_EmployeeID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_PaymentAdvice_ProjectsID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_PaymentAdvice_ProjectsID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_PaymentAdvice_ProjectsID(value, this.validated_FK_SPMT_PaymentAdvice_ProjectsID);
      },
    validated_FK_SPMT_PaymentAdvice_ProjectsID_main: false,
    validated_FK_SPMT_PaymentAdvice_ProjectsID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtPaymentAdvice.validated_FK_SPMT_PaymentAdvice_ProjectsID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_PaymentAdvice_WBS: function(o,Prefix) {
      var value = o.id;
      var ElementID = $get(Prefix + 'ElementID');
      if(ElementID.value==''){
        if(this.validated_FK_SPMT_PaymentAdvice_WBS_main){
          var o_d = $get(Prefix + 'ElementID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ElementID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_PaymentAdvice_WBS(value, this.validated_FK_SPMT_PaymentAdvice_WBS);
      },
    validated_FK_SPMT_PaymentAdvice_WBS_main: false,
    validated_FK_SPMT_PaymentAdvice_WBS: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtPaymentAdvice.validated_FK_SPMT_PaymentAdvice_WBS_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_PaymentAdvice_BPID: function(o,Prefix) {
      var value = o.id;
      var BPID = $get(Prefix + 'BPID');
      if(BPID.value==''){
        if(this.validated_FK_SPMT_PaymentAdvice_BPID_main){
          var o_d = $get(Prefix + 'BPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_PaymentAdvice_BPID(value, this.validated_FK_SPMT_PaymentAdvice_BPID);
      },
    validated_FK_SPMT_PaymentAdvice_BPID_main: false,
    validated_FK_SPMT_PaymentAdvice_BPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtPaymentAdvice.validated_FK_SPMT_PaymentAdvice_BPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
