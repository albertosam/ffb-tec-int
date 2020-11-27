import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { FilterPipe } from './filter.pipe';

@NgModule({
    declarations: [
        FilterPipe
    ],
    exports: [
        FilterPipe
    ]
})
export class CoreModule { }
