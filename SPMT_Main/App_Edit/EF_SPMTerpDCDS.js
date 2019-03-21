<script type="text/javascript"> 
var script_SPMTerpDCDS = {
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
    validate_HSNSACCode: function(sender) {
      var Prefix = sender.id.replace('HSNSACCode','');
      this.validated_FK_SPMT_erpDCDS_HSNSACCode_main = true;
      this.validate_FK_SPMT_erpDCDS_HSNSACCode(sender,Prefix);
      },
    validate_FK_SPMT_erpDCDS_HSNSACCode: function(o,Prefix) {
      var value = o.id;
      var BillTypeID = $get(Prefix + 'BillTypeID');
      if(BillTypeID.value==''){
        if(this.validated_FK_SPMT_erpDCDS_HSNSACCode_main){
          var o_d = $get(Prefix + 'BillTypeID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BillTypeID.value ;
      var HSNSACCode = $get(Prefix + 'HSNSACCode');
      if(HSNSACCode.value==''){
        if(this.validated_FK_SPMT_erpDCDS_HSNSACCode_main){
          var o_d = $get(Prefix + 'HSNSACCode' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + HSNSACCode.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCDS_HSNSACCode(value, this.validated_FK_SPMT_erpDCDS_HSNSACCode);
      },
    validated_FK_SPMT_erpDCDS_HSNSACCode_main: false,
    validated_FK_SPMT_erpDCDS_HSNSACCode: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCDS.validated_FK_SPMT_erpDCDS_HSNSACCode_main){
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
