<script type="text/javascript"> 
var script_SPMTerpDCInventory = {
    ACEChallanID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ChallanID','');
      var F_ChallanID = $get(sender._element.id);
      var F_ChallanID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ChallanID.value = p[0];
      F_ChallanID_Display.innerHTML = e.get_text();
    },
    ACEChallanID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ChallanID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEChallanID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACESerialNo_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('SerialNo','');
      var F_SerialNo = $get(sender._element.id);
      var F_SerialNo_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_SerialNo.value = p[1];
      F_SerialNo_Display.innerHTML = e.get_text();
    },
    ACESerialNo_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('SerialNo','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACESerialNo_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEHSNSACCode_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('HSNSACCode','');
      var F_HSNSACCode = $get(sender._element.id);
      var F_HSNSACCode_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_HSNSACCode.value = p[1];
      F_HSNSACCode_Display.innerHTML = e.get_text();
    },
    ACEHSNSACCode_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('HSNSACCode','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_BillTypeID = $get(Prefix + 'BillTypeID');
      sender._contextKey = F_BillTypeID.value;
    },
    ACEHSNSACCode_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsignerBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      var F_ConsignerBPID = $get(sender._element.id);
      var F_ConsignerBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerBPID.value = p[0];
      F_ConsignerBPID_Display.innerHTML = e.get_text();
    },
    ACEConsignerBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConsignerBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsignerGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      var F_ConsignerGSTIN = $get(sender._element.id);
      var F_ConsignerGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerGSTIN.value = p[1];
      F_ConsignerGSTIN_Display.innerHTML = e.get_text();
    },
    ACEConsignerGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      sender._contextKey = F_ConsignerBPID.value;
    },
    ACEConsignerGSTIN_Populated: function(sender,e) {
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
    validate_ChallanID: function(sender) {
      var Prefix = sender.id.replace('ChallanID','');
      this.validated_FK_SPMT_erpDCInventory_ChallanID_main = true;
      this.validate_FK_SPMT_erpDCInventory_ChallanID(sender,Prefix);
      },
    validate_SerialNo: function(sender) {
      var Prefix = sender.id.replace('SerialNo','');
      this.validated_FK_SPMT_erpDCInventory_SerialNo_main = true;
      this.validate_FK_SPMT_erpDCInventory_SerialNo(sender,Prefix);
      },
    validate_HSNSACCode: function(sender) {
      var Prefix = sender.id.replace('HSNSACCode','');
      this.validated_FK_SPMT_erpDCInventory_HSNSACCode_main = true;
      this.validate_FK_SPMT_erpDCInventory_HSNSACCode(sender,Prefix);
      },
    validate_ConsignerBPID: function(sender) {
      var Prefix = sender.id.replace('ConsignerBPID','');
      this.validated_FK_SPMT_erpDCInventory_ConsignerBPID_main = true;
      this.validate_FK_SPMT_erpDCInventory_ConsignerBPID(sender,Prefix);
      },
    validate_ConsignerGSTIN: function(sender) {
      var Prefix = sender.id.replace('ConsignerGSTIN','');
      this.validated_FK_SPMT_erpDCInventory_ConsignerGSTIN_main = true;
      this.validate_FK_SPMT_erpDCInventory_ConsignerGSTIN(sender,Prefix);
      },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_erpDCInventory_ProjectID_main = true;
      this.validate_FK_SPMT_erpDCInventory_ProjectID(sender,Prefix);
      },
    validate_FK_SPMT_erpDCInventory_ProjectID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_ProjectID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_ProjectID(value, this.validated_FK_SPMT_erpDCInventory_ProjectID);
      },
    validated_FK_SPMT_erpDCInventory_ProjectID_main: false,
    validated_FK_SPMT_erpDCInventory_ProjectID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_ProjectID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCInventory_ChallanID: function(o,Prefix) {
      var value = o.id;
      var ChallanID = $get(Prefix + 'ChallanID');
      if(ChallanID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_ChallanID_main){
          var o_d = $get(Prefix + 'ChallanID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ChallanID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_ChallanID(value, this.validated_FK_SPMT_erpDCInventory_ChallanID);
      },
    validated_FK_SPMT_erpDCInventory_ChallanID_main: false,
    validated_FK_SPMT_erpDCInventory_ChallanID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_ChallanID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCInventory_HSNSACCode: function(o,Prefix) {
      var value = o.id;
      var BillTypeID = $get(Prefix + 'BillTypeID');
      if(BillTypeID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_HSNSACCode_main){
          var o_d = $get(Prefix + 'BillTypeID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BillTypeID.value ;
      var HSNSACCode = $get(Prefix + 'HSNSACCode');
      if(HSNSACCode.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_HSNSACCode_main){
          var o_d = $get(Prefix + 'HSNSACCode' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + HSNSACCode.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_HSNSACCode(value, this.validated_FK_SPMT_erpDCInventory_HSNSACCode);
      },
    validated_FK_SPMT_erpDCInventory_HSNSACCode_main: false,
    validated_FK_SPMT_erpDCInventory_HSNSACCode: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_HSNSACCode_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCInventory_ConsignerGSTIN: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
      var ConsignerGSTIN = $get(Prefix + 'ConsignerGSTIN');
      if(ConsignerGSTIN.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_ConsignerGSTIN(value, this.validated_FK_SPMT_erpDCInventory_ConsignerGSTIN);
      },
    validated_FK_SPMT_erpDCInventory_ConsignerGSTIN_main: false,
    validated_FK_SPMT_erpDCInventory_ConsignerGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_ConsignerGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCInventory_ConsignerBPID: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_ConsignerBPID_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_ConsignerBPID(value, this.validated_FK_SPMT_erpDCInventory_ConsignerBPID);
      },
    validated_FK_SPMT_erpDCInventory_ConsignerBPID_main: false,
    validated_FK_SPMT_erpDCInventory_ConsignerBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_ConsignerBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCInventory_SerialNo: function(o,Prefix) {
      var value = o.id;
      var ChallanID = $get(Prefix + 'ChallanID');
      if(ChallanID.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_SerialNo_main){
          var o_d = $get(Prefix + 'ChallanID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ChallanID.value ;
      var SerialNo = $get(Prefix + 'SerialNo');
      if(SerialNo.value==''){
        if(this.validated_FK_SPMT_erpDCInventory_SerialNo_main){
          var o_d = $get(Prefix + 'SerialNo' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + SerialNo.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCInventory_SerialNo(value, this.validated_FK_SPMT_erpDCInventory_SerialNo);
      },
    validated_FK_SPMT_erpDCInventory_SerialNo_main: false,
    validated_FK_SPMT_erpDCInventory_SerialNo: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCInventory.validated_FK_SPMT_erpDCInventory_SerialNo_main){
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
