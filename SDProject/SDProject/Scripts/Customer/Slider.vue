<template>
    <div class="container" id="slider">
        <!-- container Begin -->

        <div class="col-md-12">
            <!-- col-md-12 Begin -->

            <div class="carousel slide" id="myCarousel" data-ride="carousel">
                <!-- carousel slide Begin -->

                <ol class="carousel-indicators">
                    <!-- carousel-indicators Begin -->

                    <li class="active" data-target="#myCarousel" data-slide-to="0"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                    <li data-target="#myCarousel" data-slide-to="3"></li>

                </ol><!-- carousel-indicators Finish -->

                <div class="carousel-inner">
                    <!-- carousel-inner Begin -->

                    <div class="item active">

                        <img src="../../wwwroot/images/slide-1.jpg" alt="Slider Image 1">

                    </div>

                    <div class="item">

                        <img src="../../wwwroot/images/slide-2.png" alt="Slider Image 2">

                    </div>

                    <div class="item">

                        <img src="../../wwwroot/images/slide-3.jpeg" alt="Slider Image 3">

                    </div>

                    <div class="item">

                        <img src="../../wwwroot/images/slide-4.jpg" alt="Slider Image 4">

                    </div>

                </div><!-- carousel-inner Finish -->

                <a href="#myCarousel" class="left carousel-control" data-slide="prev">
                    <!-- left carousel-control Begin -->

                    <span class="glyphicon glyphicon-chevron-left"></span>
                    <span class="sr-only">Previous</span>

                </a><!-- left carousel-control Finish -->

                <a href="#myCarousel" class="right carousel-control" data-slide="next">
                    <!-- left carousel-control Begin -->

                    <span class="glyphicon glyphicon-chevron-right"></span>
                    <span class="sr-only">Next</span>

                </a><!-- left carousel-control Finish -->

            </div><!-- carousel slide Finish -->

        </div><!-- col-md-12 Finish -->

    </div><!-- container Finish -->

</template>
<script>
export default {
        name: "Slider"
}
</script>
<style scoped>
    #slider {
        margin-bottom: 40px;
    }
</style>