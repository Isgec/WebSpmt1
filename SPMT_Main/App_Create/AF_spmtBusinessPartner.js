<script type="text/javascript"> 
var script_spmtBusinessPartner = {
    validate_BPID: function(sender) {
      var Prefix = sender.id.replace('BPID','');
      this.validatePK_spmtBusinessPartner(sender,Prefix);
      },
    validatePK_spmtBusinessPartner: function(o,Prefix) {
      var value = o.id;
      try{$get(Prefix.replace('_F_','') + '_L_ErrMsgspmtBusinessPartner').innerHTML = '';}catch(ex){}
      var BPID = $get(Prefix + 'BPID');
      if(BPID.value=='')
        return true;
      value = value + ',' + BPID.value ;
      o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
      o.style.backgroundRepeat= 'no-repeat';
      o.style.backgroundPosition = 'right';
      PageMethods.validatePK_spmtBusinessPartner(value, this.validatedPK_spmtBusinessPartner);
    },
    validatedPK_spmtBusinessPartner: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        try{$get('cph1_FVspmtBusinessPartner_L_ErrMsgspmtBusinessPartner').innerHTML = p[2];}catch(ex){}
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
