import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ApplicationComponent } from './application/application.component'
import { ArchiveComponent } from './archive/archive.component'
import { FrontPageComponent } from './front-page/front-page.component'


const routes: Routes = [
  { path: 'application', component: ApplicationComponent },
  { path: 'archive', component: ArchiveComponent },
  { path: 'front-page', component: FrontPageComponent },
  { path: '', redirectTo: '/front-page', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
