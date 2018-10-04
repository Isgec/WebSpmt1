<script type="text/javascript"> 
var script_spmtBPGSTIN = {
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
    temp: function() {
    }
    }
</script>
