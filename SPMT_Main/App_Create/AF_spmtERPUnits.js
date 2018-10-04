<script type="text/javascript"> 
var script_spmtERPUnits = {
    validate_UOM: function(sender) {
      var Prefix = sender.id.replace('UOM','');
      this.validatePK_spmtERPUnits(sender,Prefix);
      },
    validatePK_spmtERPUnits: function(o,Prefix) {
      var value = o.id;
      try{$get(Prefix.replace('_F_','') + '_L_ErrMsgspmtERPUnits').innerHTML = '';}catch(ex){}
      var UOM = $get(Prefix + 'UOM');
      if(UOM.value=='')
        return true;
      value = value + ',' + UOM.value ;
      o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
      o.style.backgroundRepeat= 'no-repeat';
      o.style.backgroundPosition = 'right';
      PageMethods.validatePK_spmtERPUnits(value, this.validatedPK_spmtERPUnits);
    },
    validatedPK_spmtERPUnits: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        try{$get('cph1_FVspmtERPUnits_L_ErrMsgspmtERPUnits').innerHTML = p[2];}catch(ex){}
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
