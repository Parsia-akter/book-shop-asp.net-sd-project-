<template>
    <section>
        <div class="panel panel-default sidebar-menu">
            <!-- panel panel-default sidebar-menu Begin -->
            <div class="panel-heading">
                <!-- panel-heading Begin -->
                <h3 class="panel-title">Products Categories</h3>
            </div><!-- panel-heading Finish -->

            <div class="panel-body">
                <!-- panel-body Begin -->
                <ul class="nav nav-pills nav-stacked category-menu">
                    <!-- nav nav-pills nav-stacked category-menu Begin -->

                    <li><a href="#">Comic Book</a></li>
                    <li><a href="#">Detective-Mystery.</a></li>
                    <li><a href="#">Graphic Novel</a></li>
                    <li><a href="#">Literary Fiction.</a></li>
                    <li><a href="#">Other...</a></li>

                </ul><!-- nav nav-pills nav-stacked category-menu Finish -->
            </div><!-- panel-body Finish -->

        </div><!-- panel panel-default sidebar-menu Finish -->


        <div class="panel panel-default sidebar-menu">
            <!-- panel panel-default sidebar-menu Begin -->
            <div class="panel-heading">
                <!-- panel-heading Begin -->
                <h3 class="panel-title">Shop Name</h3>
            </div><!-- panel-heading Finish -->

            <div class="panel-body">
                <!-- panel-body Begin -->
                <ul class="nav nav-pills nav-stacked category-menu">
                    <!-- nav nav-pills nav-stacked category-menu Begin -->

                    <li><a href="#">X...</a></li>
                    <li><a href="#">W...</a></li>
                    <li><a href="#">Z...</a></li>
                    <li><a href="#">Q...</a></li>

                </ul><!-- nav nav-pills nav-stacked category-menu Finish -->
            </div><!-- panel-body Finish -->

        </div><!-- panel panel-default sidebar-menu Finish -->
    </section>
</template>
<script>
    export default {
        name: "TheSidebar"
    }
</script>
<style scoped>

    /*  Products Categories & Categories Styles */
    #content .panel.sidebar-menu {
        box-sizing: border-box;
        box-shadow: 0px 1px 5px rgba(0, 0, 0, .5);
    }

        #content .panel.sidebar-menu ul.nav.category-menu {
            margin-bottom: 20px;
        }

            #content .panel.sidebar-menu ul.nav.category-menu li a {
                text-transform: uppercase;
                font-weight: 600;
            }

        #content .panel.sidebar-menu h3 {
            padding: 5px 0px;
            margin: 0px;
        }

    /*  Shop Products Tyles  */

    @media(max-width: 768px) {
        .center-responsive {
            width: 70%;
            margin: 0px auto;
        }
    }

    @media(max-width: 550px) {
        .center-responsive {
            width: 95%;
            margin: 0px auto;
        }
    }
</style>